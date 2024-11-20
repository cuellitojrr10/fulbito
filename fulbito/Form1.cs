﻿using Futbol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fulbito
{
    public partial class Form1 : Form
    {
        Persistencia pe = new Persistencia();

        public Form1()
        {

            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pe.CargarDeXml("jugadores.xml");
            Jugador jugador = new Jugador {
                Nombre = textBox3.Text, 
                Posicion = textBox2.Text, 
                Edad = int.Parse(textBox1.Text) };
            // Mostrar detalles del jugador en la etiqueta lblDetalles.Text = jugador.ObtenerDetalles();
            pe.AgregarJugador(jugador);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pe.ObtenerDataTable();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
