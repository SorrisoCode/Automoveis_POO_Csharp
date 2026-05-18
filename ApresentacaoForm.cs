using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace POO
{
    internal class ApresentacaoForm : Form
    {
        Label titulo01 = new Label();
        Label titulo02 = new Label();
        Label titulo03 = new Label();
        Label titulo04 = new Label();
        Label titulo05 = new Label();

        Automovel obj01 = new Automovel("Fiat", "Uno", "180km/h", 2020, "img.png");

        Label txtMarca = new Label();
        Label txtModelo = new Label();
        Label txtVelocidade = new Label();
        Label txtAno = new Label();
        Label txtImagem = new Label();
        Label txtTipo = new Label();
        Label txtFrear = new Label();

        Button btobj01 = new Button();
        Button btobj02 = new Button();
        Button btobj03 = new Button();
        Button btobj04 = new Button();

        Button btAcelerar = new Button();
        Button btFrear = new Button();

        Button btCorvette = new Button();
        Button btFusca = new Button();

        PictureBox img = new PictureBox();

        int velocidadeAtual = 0;

        public ApresentacaoForm()
        {
            this.Text = "Apresentação";
            this.Size = new Size(950, 700);
            this.Font = new Font("Arial", 12);

            titulo01.Text = "Descrição dos veículos";
            titulo01.Font = new Font("Arial", 16);
            titulo01.AutoSize = true;

            this.Controls.Add(titulo01);

            CentralizarTitulo();

            titulo01.Top = 20;

            txtFrear.AutoSize = true;
            txtTipo.AutoSize = true;

            txtMarca.AutoSize = true;
            txtModelo.AutoSize = true;
            txtAno.AutoSize = true;
            txtVelocidade.AutoSize = true;

            btobj01.Text = "Uno";
            btobj01.Click += clicar;

            btobj02.Text = "Opala";
            btobj02.Click += clicar2;

            btobj03.Text = "Camaro";
            btobj03.Click += clicar3;

            btCorvette.Text = "Corvette";
            btCorvette.Click += clicar4;

            btFusca.Text = "Fusca";
            btFusca.Click += clicar5;

            //herança
            btAcelerar.Text = "Acelerar";
            btAcelerar.Click += clicarAcelerar;

            btFrear.Text = "Frear";
            btFrear.Click += clicarFrear;

            titulo02.Location = new Point(105, 105);
            titulo02.AutoSize = true;

            titulo03.Location = new Point(110, 110);
            titulo03.AutoSize = true;

            Control[] elementos =
            {
                titulo01,
                titulo02,
                txtMarca,
                btobj01,
                txtModelo,
                txtAno,
                txtVelocidade,
                txtImagem,
                btobj02,
                btobj03,
                btCorvette,
                btAcelerar,
                btFrear,
                txtTipo,
                txtFrear,
                btFusca
            };

            this.Controls.AddRange(elementos);

            CentralizarBotoes();

            this.Resize += (s, e) =>
            {
                CentralizarTitulo();

                CentralizarBotoes();
                CentralizarConteudo();
            };

            img.Width = 320;
            img.Height = 240;
            img.SizeMode = PictureBoxSizeMode.Zoom;

            this.Controls.Add(img);

            foreach (Control c in this.Controls)
            {
                if (c is Button b)
                {
                    b.TabStop = false;
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderSize = 1;

                    // acelerar e frear
                    if (b == btAcelerar || b == btFrear)
                    {
                        b.BackColor = Color.Gray;
                        b.ForeColor = Color.White;

                        b.FlatAppearance.MouseOverBackColor = Color.DimGray;
                        b.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        b.BackColor = Color.LightGray;
                        b.ForeColor = Color.Black;

                        b.FlatAppearance.MouseOverBackColor = Color.DarkGray;
                        b.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                    }
                }
            }
        }

        private void CentralizarTitulo()
        {
            titulo01.Left = (this.ClientSize.Width - titulo01.Width) / 2;
        }

        //centraliza
        private void CentralizarBotoes()
        {
            Button[] botoes =
            {
                btobj01,
                btobj02,
                btobj03,
                btCorvette,
                btFusca,
                btAcelerar,
                btFrear
            };

            int larguraBotao = 100;
            int alturaBotao = 35;
            int espacamento = 15;

            int totalLargura =
                (botoes.Length * larguraBotao) +
                ((botoes.Length - 1) * espacamento);

            int startX = (this.ClientSize.Width - totalLargura) / 2;
            int y = 80;

            for (int i = 0; i < botoes.Length; i++)
            {
                botoes[i].Size = new Size(larguraBotao, alturaBotao);

                botoes[i].Location = new Point(
                    startX + i * (larguraBotao + espacamento),
                    y
                );
            }
        }

        private void CentralizarConteudo()
        {
            int centro = this.ClientSize.Width / 2;

            txtMarca.Left = centro - (txtMarca.Width / 2);
            txtModelo.Left = centro - (txtModelo.Width / 2);
            txtAno.Left = centro - (txtAno.Width / 2);
            txtVelocidade.Left = centro - (txtVelocidade.Width / 2);
            txtFrear.Left = centro - (txtFrear.Width / 2);

            txtMarca.Top = 170;
            txtModelo.Top = 205;
            txtAno.Top = 240;
            txtVelocidade.Top = 275;
            txtFrear.Top = 315;

            img.Left = centro - (img.Width / 2);
            img.Top = 355;
        }

        private void clicar(object sender, EventArgs e)
        {
            obj01.Marca = "Fiat";
            obj01.Modelo = "Uno";
            obj01.Ano = 2020;

            velocidadeAtual = 180;

            txtMarca.Text = "Marca: " + obj01.Marca;
            txtModelo.Text = "Modelo: " + obj01.Modelo;
            txtAno.Text = "Ano: " + obj01.Ano;
            txtVelocidade.Text = "Velocidade: " + velocidadeAtual + " km/h";

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\source\\repos\\Automoveis_POO_Csharp\\img\\fiat.jpg");

            CentralizarConteudo();
        }

        private void clicar2(object sender, EventArgs e)
        {
            obj01.Marca = "Chevrolet";
            obj01.Modelo = "Opala";
            obj01.Ano = 1980;

            velocidadeAtual = 170;

            txtMarca.Text = "Marca: " + obj01.Marca;
            txtModelo.Text = "Modelo: " + obj01.Modelo;
            txtAno.Text = "Ano: " + obj01.Ano;
            txtVelocidade.Text = "Velocidade: " + velocidadeAtual + " km/h";

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\source\\repos\\Automoveis_POO_Csharp\\img\\opala.jpg");

            CentralizarConteudo();
        }

        private void clicar3(object sender, EventArgs e)
        {
            obj01.Marca = "Chevrolet";
            obj01.Modelo = "Camaro";
            obj01.Ano = 2007;

            velocidadeAtual = 250;

            txtMarca.Text = "Marca: " + obj01.Marca;
            txtModelo.Text = "Modelo: " + obj01.Modelo;
            txtAno.Text = "Ano: " + obj01.Ano;
            txtVelocidade.Text = "Velocidade: " + velocidadeAtual + " km/h";

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\source\\repos\\Automoveis_POO_Csharp\\img\\camaro.jpg");

            CentralizarConteudo();
        }

        private void clicar4(object sender, EventArgs e)
        {
            obj01.Marca = "Chevrolet";
            obj01.Modelo = "Corvette C6";
            obj01.Ano = 2008;

            velocidadeAtual = 300;

            txtMarca.Text = "Marca: " + obj01.Marca;
            txtModelo.Text = "Modelo: " + obj01.Modelo;
            txtAno.Text = "Ano: " + obj01.Ano;
            txtVelocidade.Text = "Velocidade: " + velocidadeAtual + " km/h";

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\source\\repos\\Automoveis_POO_Csharp\\img\\corvette.jpg");

            CentralizarConteudo();
        }

        private void clicar5(object sender, EventArgs e)
        {
            obj01.Marca = "Volkswagen";

            obj01.Modelo = "Fusca";

            obj01.Ano = 1953;

            velocidadeAtual = 100;

            txtMarca.Text = "Marca: " + obj01.Marca;
            txtModelo.Text = "Modelo: " + obj01.Modelo;
            txtAno.Text = "Ano: " + obj01.Ano;
            txtVelocidade.Text = "Velocidade: " + velocidadeAtual + " km/h";

            img.Image = Image.FromFile("C:\\Users\\LabInfo\\source\\repos\\Automoveis_POO_Csharp\\img\\fusca.jpg");

            CentralizarConteudo();
        }

        private void clicarAcelerar(object sender, EventArgs e)
        {
            velocidadeAtual += 10;

            txtVelocidade.Text =
                "Velocidade: " + velocidadeAtual + " km/h";

            txtFrear.Text =
                "Acelerando o carro...";

            CentralizarConteudo();
        }

        private void clicarFrear(object sender, EventArgs e)
        {
            velocidadeAtual -= 10;

            if (velocidadeAtual < 0)
            {
                velocidadeAtual = 0;
            }

            txtVelocidade.Text =
                "Velocidade: " + velocidadeAtual + " km/h";

            txtFrear.Text =
                "Freando o carro...";

            CentralizarConteudo();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(320, 363);
            this.Name = "ApresentacaoForm";
            this.Load += new System.EventHandler(this.ApresentacaoForm_Load);

            this.ResumeLayout(false);
        }

        private void ApresentacaoForm_Load(object sender, EventArgs e)
        {

        }
    }
}