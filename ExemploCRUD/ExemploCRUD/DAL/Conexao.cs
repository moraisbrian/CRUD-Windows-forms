﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; //Trabalhar com dados.
using System.Data.SqlClient; //Cliente do servidor SQLServer.

namespace ExemploCRUD.DAL
{
    class Conexao
    {
        //Declarar uma variavel de conexao com o SQL.
        SqlConnection con;

        //Metodo construtor (que é execultado sempre que um objeto desta classe é instanciado).
        public Conexao()
        {
            //Instanciar o objeto sqlconection.
            con = new SqlConnection();
            //Configurar a conexao (caminho do servidor, base de dados, autenticação).
            con.ConnectionString = "Data Source = ";
            con.ConnectionString += Properties.Settings.Default.EnderecoServidorSQL;
            con.ConnectionString += ";Initial Catalog = ";
            con.ConnectionString += Properties.Settings.Default.NomeBaseDeDados;
            con.ConnectionString += "; Integrated Security = true";
        }

        public SqlConnection Conectar()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
