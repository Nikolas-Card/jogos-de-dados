

/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 03/12/2021
 * Time: 21:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Media;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tabuleiro
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
			panel1.Parent = this;
			
			
			
		}
		Random rnd = new Random();
			
			
		void Button1Click(object sender, System.EventArgs e)
		{
			SoundPlayer simpleSound = new SoundPlayer(@"somdado.wav");
			simpleSound.Play();	
			int n1 = rnd.Next(1,7);
			button1.BackgroundImage = Image.FromFile("dado"+n1+".png");
			//player.SoundLocation= SoundPlayer("dadosom.mpeg");

			
			//throw new NotImplementedException();
		}
		
		void panel1Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel1.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel1.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel2Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel2.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel2.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel3Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel3.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel3.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}

		void panel4Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel4.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel4.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}
		
		void panel5Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel5.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel5.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel6Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel6.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel6.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel7Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel7.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel7.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}

		void panel8Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel8.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel8.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}
		
		void panel9Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel9.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel9.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel10Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel10.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel10.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel11Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel11.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel11.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}
		
		void panel12Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel12.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel12.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel13Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel13.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel13.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}

		void panel14Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel14.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel14.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}
		
		void panel15Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel15.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel15.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel16Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel16.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel16.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel17Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel17.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel17.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}

		void panel18Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel18.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel18.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}
		
		void panel19Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel19.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel19.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel20Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel20.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel20.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel21Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel21.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel21.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}

		void panel22Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel22.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel22.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}
		
		void panel23Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel23.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel23.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel24Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel24.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel24.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel25Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel25.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel25.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}

		void panel26Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel26.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel26.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}
		
		void panel27Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel27.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel27.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel28Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel28.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel28.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel29Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel29.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel29.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}

		void panel30Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel30.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel30.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}
		
		void panel31Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel31.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel31.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel32Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel32.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel32.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel33Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel33.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel33.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}

		void panel34Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel34.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel34.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}
		
		void panel35Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel35.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel35.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel36Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel36.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel36.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}

		void panel37Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel37.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel37.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel38Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel38.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel38.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}

		void panel39Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel39.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel39.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}
		
		void panel40Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel40.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel40.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel41Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel41.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel41.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel42Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel42.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel42.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}

		void panel43Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel43.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel43.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}
		
		void panel44Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel44.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel44.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel45Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel45.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel45.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel46Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel46.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel46.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}

		void panel47Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel47.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel47.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}
		
		void panel48Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel48.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel48.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel49Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel49.BackgroundImage=Image.FromFile("pino1.png");
			}else if(radioButton2.Checked) {
				panel49.BackgroundImage=Image.FromFile("pino2.png");
			}
				
		}		
		
		void panel50Click(object sender, EventArgs e){
			if(radioButton1.Checked){
				panel50.BackgroundImage=Image.FromFile("pino1.png");
				MessageBox.Show("Parabens!!\r \r Jogador 1 Campeão");
			}else if(radioButton2.Checked) {
				panel50.BackgroundImage=Image.FromFile("pino2.png");
				MessageBox.Show("Parabens!!\r \r Jogador 2 Campeão");
			}
				
		}

	}
}