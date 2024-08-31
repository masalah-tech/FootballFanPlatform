namespace FFP.WebApp.Data.sql
{
    public class AdminSqlScript
    {
        public static string GetListQuery()
        {
            return "select * from Admins";
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
