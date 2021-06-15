using System;
using System.Drawing;
using static System.Console;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Injection Types
            #region Constructor Injectin
            var aracYonetimi = new AracYonetimi(new Ford("Ford", "Focus", Color.Red, 2));
            aracYonetimi.TekerSayisiDegistir(4);
            aracYonetimi.ModelDegistir("Fiesta");
            aracYonetimi.RenkDegistir(Color.Blue);

            WriteLine(aracYonetimi.TumOzellikler());
            #endregion
            #region Method Injection
            
            #endregion
            #region Property Injection
 
            #endregion
            #endregion
            ReadLine();
        }
    }

    #region Injection Types
    #region Contructor Injection
    class AracYonetimi
    {
        readonly IAraba _araba;

        public AracYonetimi(IAraba araba)
        {
            _araba = araba;
        }

        public void RenkDegistir(Color renk) => _araba.Renk = renk;

        public void ModelDegistir(string model) => _araba.Model = model;

        public void TekerSayisiDegistir(byte tekerSayisi) => _araba.TekerSayisi = tekerSayisi;

        public string TumOzellikler()
        {
            var arry = new string[4];
            arry[0] = $"{nameof(_araba.TekerSayisi)}:{_araba.TekerSayisi}";
            arry[1] = $"{nameof(_araba.Renk)}:{_araba.Renk}";
            arry[3] = $"{nameof(_araba.Marka)}:{_araba.Marka}";
            arry[2] = $"{nameof(_araba.Model)}:{_araba.Model}";
            return string.Join(Environment.NewLine, arry);
        }
    }
    #endregion
    #region  Method Injection

    #endregion
    #region Property Injection

    #endregion
    #endregion

    interface IAraba
    {
        string Marka { get; set; }
        string Model { get; set; }
        Color Renk { get; set; }
        byte TekerSayisi { get; set; }
    }

    class Renault : IAraba
    {
        public Renault(string marka, string model, Color renk, byte tekerSayisi)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            TekerSayisi = tekerSayisi;
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public Color Renk { get; set; }
        public byte TekerSayisi { get; set; }
    }

    class Ford : IAraba
    {
        public Ford(string marka, string model, Color renk, byte tekerSayisi)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            TekerSayisi = tekerSayisi;
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public Color Renk { get; set; }
        public byte TekerSayisi { get; set; }
    }
}