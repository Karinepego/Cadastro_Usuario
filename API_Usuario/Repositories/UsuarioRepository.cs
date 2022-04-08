using API_Usuario.Models;
using API_Usuario.Models.Entities.DTO;
using Microsoft.EntityFrameworkCore;

namespace API_Usuario.Repositories
{
    public interface IUsuarioRepository
    {
        public bool Create(PostUsuarioRequest usuario);
        public Usuario FindById(int id);
        public bool Update(PutUsuario usuario);
        public bool Delete(int id);
    }

    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly _DbContext db;
        public UsuarioRepository(_DbContext _db)
        {
            db = _db;
        }

        public bool Create(PostUsuarioRequest usuario)
        {
            try{
                var usuario_db = new Usuario()
                {
                    Nome = usuario.Nome,
                    Email = usuario.Email,
                    Cpf = usuario.Cpf,
                    Pis = usuario.Pis,
                    Senha = usuario.Senha,
                    EnderecoId = usuario.EnderecoId,
                };
                db.usuario.Add(usuario_db);
                db.SaveChanges();

                return true;

            }catch(DbUpdateException e){
                var erro = e;
                return false;
            }

        }
        public Usuario FindById(int id)
        {
            try
            {
                var usuario_db = db.usuario.Find(id);
                return usuario_db;
            }
            catch
            {
                return new Usuario();
            }
        }

        public bool Update(PutUsuario usuario)
        {
            try
            {
                var usuario_db = db.usuario.Find(usuario.Id);

                usuario_db.Nome = usuario.Nome;
                usuario_db.Email = usuario.Email;
                usuario_db.Cpf = usuario.Cpf;
                usuario_db.Pis = usuario.Pis;
                usuario_db.Senha = usuario.Senha;
                usuario_db.EnderecoId = usuario.EnderecoId;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var usuario_db = db.usuario.Find(id);
                db.usuario.Remove(usuario_db);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
