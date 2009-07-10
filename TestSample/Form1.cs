﻿using System;
using System.Windows.Forms;
using Transitions;

namespace TestSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Transition.run(this, "Opacity", 0.0, 1.0, new TransitionMethod_Deceleration(800));
        }
        
        private void button1_Click(object sender, EventArgs e)
		{
			//Left = -300;
			//Opacity = 0.6;
            //label1.Text = "Hello";

			//Transition t = new Transition(new TransitionMethod_Linear(1000));
			//t.add(this, "Left", 0);
			//t.add(this, "Opacity", 1.0);
			//t.add(label1, "Text", "A much longer piece of text");
			//t.run();

            Opacity = 0.5;

            Transition t1 = new Transition(new TransitionMethod_EaseInEaseOut(500));
            t1.add(this, "Top", 100);
            t1.add(this, "Left", 100);

            Transition t2 = new Transition(new TransitionMethod_Acceleration(1500));
            t2.add(this, "Top", 500);
            t2.add(this, "Left", 200);
            t2.add(this, "Opacity", 0.7);

            Transition t3 = new Transition(new TransitionMethod_Deceleration(1000));
            t3.add(this, "Top", 200);
            t3.add(this, "Left", 600);
            t3.add(this, "Opacity", 0.8);

            Transition t4 = new Transition(new TransitionMethod_Linear(200));
            t4.add(this, "Opacity", 1.0);

            Transition.runChain(t1, t2, t3, t4);

		}



    }
}
