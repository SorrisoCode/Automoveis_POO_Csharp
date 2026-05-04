using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Http.Headers;

namespace POO
{
    internal class ApresentacaoForm : Form
    {
        Label titulo01 = new Label(); 
        Label titulo02 = new Label();
        Label titulo03 = new Label();

        Automovel obj01 = new Automovel("Fiat", "Uno", "180km/h", 2020, "img.png");

        Label txtMarca = new Label();
        Label txtModelo = new Label();
        Label txtVelocidade = new Label();
        Label txtAno = new Label();
        Label txtImagem = new Label();
        Button btobj01 = new Button();
        Button btobj02 = new Button();
        Button btobj03 = new Button();

        PictureBox img = new PictureBox();


        public ApresentacaoForm()
        {
            this.Text = "Apresentação";
            this.Size = new Size(600, 600);

            titulo01.Text = "Botões com descrições dos veículos";
            titulo01.Font = new Font("Arial", 16);
            titulo01.AutoSize = true;
            titulo01.Location = new Point(100, 100);

            btobj01.Text = "Uno";
            btobj01.Location = new Point(50, 50);
            btobj01.Click += clicar;
            btobj02.Click += clicar2;
            btobj02.Text = "Opala";
            btobj02.Location = new Point(150, 50);

            btobj03.Click += clicar3;
            btobj03.Text = "Camaro";
            btobj03.Location = new Point(250, 50);


            titulo02.Location = new Point(105, 105);
            titulo02.AutoSize = true;
            titulo02.Text = obj01.Marca;

            titulo03.Location = new Point(110, 110);
            titulo03.AutoSize = true;
            titulo03.Text = obj01.Marca;

            Control[] elementos = { titulo01, titulo02, txtMarca, btobj01, txtModelo, txtAno, txtVelocidade, txtImagem, btobj02, btobj03 };
            this.Controls.AddRange(elementos);

            img.Location = new Point(100, 220);
            img.Size = new Size(150, 150);
            img.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Controls.Add(img);
        }

        private void clicar(object sender, EventArgs e)
        {
            //MessageBox.Show("Método de Evento");
            // usando propriedade (não usa mais Set/Get)
            obj01.Marca = "Fiat";
            obj01.Modelo = "Uno";
            obj01.Ano = 2020;
            obj01.Velocidade = "180 km/h";

            txtMarca.Text = "Marca: " + obj01.Marca;
            txtModelo.Text = "Modelo: " + obj01.Modelo;
            txtAno.Text = "Ano: " + obj01.Ano;
            txtVelocidade.Text = "Velocidade: " + obj01.Velocidade;

            txtMarca.Location = new Point(100, 140);
            txtModelo.Location = new Point(100, 170);
            txtAno.Location = new Point(100, 200);
            txtVelocidade.Location = new Point(100, 230);
            txtMarca.AutoSize = true;
            txtModelo.AutoSize = true;
            txtAno.AutoSize = true;
            txtVelocidade.AutoSize = true;

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\Downloads\\POOtudo\\img\\fiat.jpg");
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            this.img.Location = new Point(100, 290);
            img.Width = 200;
            img.Height = 150;
        }
        private void clicar2(object sender, EventArgs e)
        {
            obj01.Marca = "Chevrolet";
            obj01.Modelo = "Opala";
            obj01.Ano = 1980;
            obj01.Velocidade = "170 km/h";

            txtMarca.Text = "Marca: " + obj01.Marca;
            txtModelo.Text = "Modelo: " + obj01.Modelo;
            txtAno.Text = "Ano: " + obj01.Ano;
            txtVelocidade.Text = "Velocidade: " + obj01.Velocidade;

            txtMarca.Location = new Point(100, 140);
            txtModelo.Location = new Point(100, 170);
            txtAno.Location = new Point(100, 200);
            txtVelocidade.Location = new Point(100, 230);
            txtMarca.AutoSize = true;
            txtModelo.AutoSize = true;
            txtAno.AutoSize = true;
            txtVelocidade.AutoSize = true;

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\Downloads\\POOtudo\\img\\opala.jpg");
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            this.img.Location = new Point(100, 290);
            img.Width = 200;
            img.Height = 150;
        }
        private void clicar3(object sender, EventArgs e)
        {
            obj01.Marca = "Chevrolet";
            obj01.Modelo = "Camaro";
            obj01.Ano = 2007;
            obj01.Velocidade = "250 km/h";

            txtMarca.Text = "Marca: " + obj01.Marca;
            txtModelo.Text = "Modelo: " + obj01.Modelo;
            txtAno.Text = "Ano: " + obj01.Ano;
            txtVelocidade.Text = "Velocidade: " + obj01.Velocidade;

            txtMarca.Location = new Point(100, 140);
            txtModelo.Location = new Point(100, 170);
            txtAno.Location = new Point(100, 200);
            txtVelocidade.Location = new Point(100, 230);
            txtMarca.AutoSize = true;
            txtModelo.AutoSize = true;
            txtAno.AutoSize = true;
            txtVelocidade.AutoSize = true;

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\Downloads\\POOtudo\\img\\camaro.jpg");//corrigir caminho
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            this.img.Location = new Point(100, 290);
            img.Width = 200;
            img.Height = 150;
        }
    }
}