select * from t_userRols
select * from t_users

INSERT INTO t_userRols(Id, [Title], Description, IsActive)VALUES(1, 'Administrador', 'Todos los permisos', 1),(2, 'Formador', 'Permiso instructor', 1),(3, 'Coder', 'Permiso estudiante', 1)

INSERT INTO t_users
(UserRolId, UserName, LastName, Email, InsertDate, UpdateDate, IsActive, EncryptedPassword, EncryptedToken, TokenExpireDate)
VALUES
(1, 'Admin', 'Admin.Pedagogía', 'admin.pedagogía@gmail.com', GETDATE(), GETDATE(), 1, '$2a$11$V6c1zrNzHljeiIQ81bLaoeogagZWvr2JUkUs8CHmWzHYJ6T2l0S5q', '', GETDATE())
--la pass es asdasd2