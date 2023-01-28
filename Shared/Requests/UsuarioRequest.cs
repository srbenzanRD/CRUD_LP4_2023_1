namespace CRUD.Shared.Requests;

public class UsuarioRequest
{
    public int Id { get; set; }
    public int UsuarioRolId { get; set; }
    public string Name { get; set; } = null!;
    public string Nickname { get; set; } = null!;
    public string Password { get; set; } = null!;
}