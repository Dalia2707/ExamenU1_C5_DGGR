using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExamenU1_C5_DGGR.ViewModel
{
    public class VMpage1 : BaseViewModel
    {
        #region VARIABLES
        bool _IMC;
        bool _FCN;
        int _peso;
        int _altura;
        int _latidos;
        int _resultadolatidos;
        int _resultadoIMC;
        #endregion
        #region CONSTRUCTOR
        public VMpage1(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public bool IMC
        {
            get { return _IMC; }
            set
            {
                SetProperty(ref _IMC, value);
                if (_IMC)
                {
                    FCN = false;
                }
            }
        }

        public bool FCN
        {
            get { return _FCN; }
            set
            {
                SetProperty(ref _FCN, value);
                if (_FCN)
                {
                    IMC = false;
                }
            }
        }

        public int Peso
        {
            get { return _peso; }
            set { SetProperty(ref _peso, value); }
        }

        public int Altura
        {
            get { return _altura; }
            set { SetProperty(ref _altura, value); }
        }

        public int Latidos
        {
            get { return _latidos; }
            set { SetProperty(ref _latidos, value); }
        }
        public int Resultadolatidos
        {
            get { return _resultadolatidos; }
            set { SetProperty(ref _resultadolatidos, value); }
        }
        public int ResultadoIMC
        {
            get { return _resultadoIMC; }
            set { SetProperty(ref _resultadoIMC, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void procesoSimple()
        {

        }
        public void FrecuenciaCardiaca()
        {
            Resultadolatidos = Latidos * 4;

            if (60 > Resultadolatidos)
            {
                
            }
            else if (60 < Resultadolatidos && 100 < Resultadolatidos)
            {

            }
            else if (100 < Resultadolatidos)
            {

            }
        }
        public void IndiceDeMasa()
        {
            ResultadoIMC = Peso / (Altura * Altura);
        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(procesoSimple);
        public ICommand FrecuenciaCardiacacomand => new Command(FrecuenciaCardiaca);
        public ICommand IndiceDeMasacomand => new Command(IndiceDeMasa);
        #endregion
    }
}
