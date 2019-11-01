﻿using ControleDeGastos.Domain;
using ControleDeGastos.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeGastos.Repository
{
    public class UsuarioRepository : IUsuarioRepository<Usuario>
    {
        #region Atributos
        private readonly Context _context;
        private static Usuario UsuarioLogado;
        #endregion

        #region Construtor
        public UsuarioRepository(Context context) 
        {
            _context = context;
        }
        #endregion

        #region Cadastrar
        public bool Cadastrar(Usuario u)
        {
            try
            {
                if (BuscarPorCpf(u) != null)
                {
                    return false;
                }
                _context.Usuarios.Add(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region GetUsuarioLogado
        public Usuario GetUsuarioLogado()
        {
            return UsuarioLogado;
        }
        #endregion

        #region BuscarPorCpf
        public Usuario BuscarPorCpf(Usuario u)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Cpf.Equals(u.Cpf));
        }
        #endregion

        #region BuscarPorLogin
        public Usuario BuscarPorLogin(Usuario u)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Login.Equals(u.Login));
        }
        #endregion

        #region Logar
        public bool Logar(string login, string senha)
        {
            var usuario = _context.Usuarios.FirstOrDefault(x => x.Email.Equals(login) && x.Senha.Equals(senha));
            if (usuario == null)
                usuario = _context.Usuarios.FirstOrDefault(x => x.Login.Equals(login) && x.Senha.Equals(senha));
            UsuarioLogado = usuario;
            if (usuario != null)
                return true;
            else return false;
        }
        #endregion

        #region Listar
        public List<Usuario> ListarUsuarios() => _context.Usuarios.ToList();
        #endregion

        #region Editar
        public bool Editar(Usuario u)
        {
            try
            {
                _context.Entry(u).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}