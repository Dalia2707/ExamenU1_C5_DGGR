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
        string _peso;
        string _altura;
        string _latidos;
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
            set { SetProperty(ref _IMC, value); }
        }

        public bool FCN
        {
            get { return _FCN; }
            set { SetProperty(ref _FCN, value); }
        }

        public string Peso
        {
            get { return _peso; }
            set { SetProperty(ref _peso, value); }
        }

        public string Altura
        {
            get { return _altura; }
            set { SetProperty(ref _altura, value); }
        }

        public string Latidos
        {
            get { return _latidos; }
            set { SetProperty(ref _latidos, value); }
        }

        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void procesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(procesoSimple);
        #endregion
    }
}
