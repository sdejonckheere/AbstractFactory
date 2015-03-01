using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AbstractFactory shapeFactory = FactoryProducer.getFactory("Shape");

            Shape shape1 = shapeFactory.getShape("Triangle");

            shape1.draw();

            shape1 = shapeFactory.getShape("Square");

            shape1.draw();

        }
    }
}
