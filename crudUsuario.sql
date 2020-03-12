create procedure crudUsuario
@Id int=null,
@nomUsuario varchar(50)=null,
@apeUsuario varchar(50)=null,
@correo varchar(50)=null,
@idrol int,
@idMembresia int,
@CrudOption varchar(50)=null
as
begin
	if(@CrudOption='Select')
	begin
		select * from Usuario
	end
	if(@CrudOption='Details')
	begin
		select * from Usuario where idUsuario=@Id
	end
	if(@CrudOption='Insert')
	begin
		insert into Usuario values (@nomUsuario,@apeUsuario,@correo,@idrol,@idMembresia)
	end
	if(@CrudOption='Update')
	begin
		update Usuario set nomUsuario=@nomUsuario, apeUsuario=@apeUsuario, correo=@correo, idrol=@idrol, idMembresia=@idMembresia where  idUsuario=@Id
	end
	if(@CrudOption='Delete')
	begin
		Delete from Usuario where idUsuario=@Id
	end
end
