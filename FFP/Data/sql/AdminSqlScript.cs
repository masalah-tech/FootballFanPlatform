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
            return string.Format(@"SELECT * FROM Admins
                  WHERE (@SearchValue IS NULL OR FirstName LIKE @SearchValue)
                  ORDER BY 
                    CASE 
                        WHEN {2} = 0 THEN cast(Id as nvarchar(max))  
                        WHEN {2} = 2 THEN FirstName 
                        WHEN {2} = 3 THEN cast(AdminRoleId as nvarchar(max))  
                        WHEN {2} = 4 THEN Username 
                        WHEN {2} = 5 THEN EncPassword 
                        WHEN {2} = 6 THEN cast(Status as nvarchar(max))  
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
