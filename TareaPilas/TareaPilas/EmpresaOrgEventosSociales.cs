using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPilas
{
	class EmpresaOrgEventosSociales : IEquatable<EmpresaOrgEventosSociales>
	{

		public EmpresaOrgEventosSociales()
        {

        }

		private int _intNumEmpleados;

		public int NumEmpleados
		{
			get { return _intNumEmpleados; }
			set { _intNumEmpleados = value; }
		}

		private double _dblSueldoEmpleados;

		public double SueldoEmpleados
		{
			get { return _dblSueldoEmpleados; }
			set { _dblSueldoEmpleados = value; }
		}

		private char _chrRankDeCalidad;

		public char RankDeCalidad
		{
			get { return _chrRankDeCalidad; }
			set { _chrRankDeCalidad = value; }
		}

		private string _strNombreEmpresa;

		public string NombreEmpresa
		{
			get { return _strNombreEmpresa; }
			set { _strNombreEmpresa = value; }
		}

		private bool _blnCuentaConSeguroParaEmpleados = false;

		public bool CuentaConSeguroParaEmpleados
		{
			get { return _blnCuentaConSeguroParaEmpleados; }
			set { _blnCuentaConSeguroParaEmpleados = value; }
		}

		private string _strLogoEmpresaEventosSociales;//

		public string LogoEmpresaEventosSociales
		{
			get { return _strLogoEmpresaEventosSociales; }
			set { _strLogoEmpresaEventosSociales = value; }
		}

		private DateTime _dtmFechaAperturaEmpresa;//

		public DateTime FechaAperturaEmpresa
		{
			get { return _dtmFechaAperturaEmpresa; }
			set { _dtmFechaAperturaEmpresa = value; }
		}

		public bool Equals(EmpresaOrgEventosSociales OtraEmpresaOrgEventosSociales)
		{
			return (this.NombreEmpresa == OtraEmpresaOrgEventosSociales.NombreEmpresa && this.NumEmpleados == OtraEmpresaOrgEventosSociales.NumEmpleados && this.SueldoEmpleados == OtraEmpresaOrgEventosSociales.SueldoEmpleados &&
				this.RankDeCalidad == OtraEmpresaOrgEventosSociales.RankDeCalidad && this.CuentaConSeguroParaEmpleados == OtraEmpresaOrgEventosSociales.CuentaConSeguroParaEmpleados &&
				this.LogoEmpresaEventosSociales == OtraEmpresaOrgEventosSociales.LogoEmpresaEventosSociales);
		}

		public int CompareTo(EmpresaOrgEventosSociales OtraEmpresaOrgEventosSociales)
			=> string.Compare(NombreEmpresa, OtraEmpresaOrgEventosSociales.NombreEmpresa);

	}
}
