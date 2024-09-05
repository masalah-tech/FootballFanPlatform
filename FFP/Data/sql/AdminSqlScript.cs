namespace FFP.WebApp.Data.sql
{
    public class AdminSqlScript
    {
        public static string GetListQuery()
        {
            return "select * from Admins";
        }

        public static string GetPagedListQuery(int start, int length, int sortColumnIndex, string sortDirection)
        {
            return string.Format(
                @"with data as ( SELECT admn.Id, admn.PersonalPhotoPath ProfilePhotoPath, 
	                    admn.FirstName + ' ' + admn.LastName Name, rol.Title Role, admn.Username,
	                    admn.EncPassword Password, case when admn.Status = 0 then 'Inactive' else 'Active' end as Status
                    FROM Admins admn inner join AdminRoles rol on admn.AdminRoleId = rol.Id)
                    select * from data
                  WHERE (
                        @SearchValue IS NULL 
                        OR Id LIKE @SearchValue
                        OR Name LIKE @SearchValue
                        OR Role LIKE @SearchValue
                        OR Username LIKE @SearchValue
                        OR Password LIKE @SearchValue
                        OR Status LIKE @SearchValue
                    )
                  ORDER BY 
                    CASE 
                        WHEN {2} = 0 THEN cast(data.Id as nvarchar(max))  
                        WHEN {2} = 2 THEN data.Name 
                        else cast(0 as nvarchar(max)) 
                    END {3}
                  OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", start, length, sortColumnIndex, sortDirection); 
        }

        public static string GetTotalCountQuery()
        {
            return "SELECT COUNT(*) FROM Admins";
        }

        public static string GetFilteredCountQuery()
        {
            return @"SELECT COUNT(*) FROM Admins
                  WHERE (@SearchValue IS NULL OR FirstName LIKE @SearchValue)";
        }

        public static string AddQuery() 
        {
            return @"begin try
                        begin transaction;

                        insert into addresses 
                        (
                            country,
                            city,
                            street,
                            appartmentno,
                            zipcode
                        )
                        values
                        (
                            @Country,
                            @City,
                            @Street,
                            @AppartmentNo,
                            @ZipCode
                        );

                        declare @addressid nvarchar(max);
                        set @addressid = (select scope_identity());

                        insert into admins
                        (
                            username,
                            encpassword,
                            adminroleid,
                            firstname,
                            secondname,
                            thirdname,
                            lastname,
                            birthdate,
                            personalphotopath,
                            email,
                            phonenumber,
                            nationality,
                            addressid,
                            status
                        )
                        values 
                        (
                            @Username,
                            @EncPassword,
                            @AdminRoleId,
                            @FirstName,
                            @SecondName,
                            @ThirdName,
                            @LastName,
                            @BirthDate,
                            @PersonalPhotoPath,
                            @Email,
                            @PhoneNumber,
                            @Nationality,
                            @addressid,
                            @Status
                        );

                        select scope_identity();

                        commit;
                    end try
                    begin catch
                        rollback;
                        throw;
                    end catch;";
        }

        public static string GetAdminRolesQuery() 
        {
            return "select * from AdminRoles";
        }
    }
}
