using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public abstract class Persona : EntidadBase
    {
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _correo;
        private string _direccion;
        private string _identificacion;
        private DateTime _fechaNacimiento;
        private string _genero;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                if (value.Length < 5)
                    throw new ArgumentException("El nombre debe tener al menos 5 caracteres.");
                if (value.Length > 40)
                    throw new ArgumentException("El nombre no puede exceder 40 caracteres.");
                if (!Regex.IsMatch(value, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
                    throw new ArgumentException("El nombre solo puede contener letras y espacios.");
                if (Regex.IsMatch(value, @"\s{2,}"))
                    throw new ArgumentException("El nombre no puede contener espacios múltiples consecutivos.");
                if (value.StartsWith(" ") || value.EndsWith(" "))
                    throw new ArgumentException("El nombre no puede iniciar o terminar con espacios.");
                if (Regex.IsMatch(value, @"^[\-'\.]+"))
                    throw new ArgumentException("El nombre no puede iniciar con caracteres especiales.");
                string[] palabras = value.Split(' ');
                foreach (string palabra in palabras)
                {
                   if (!string.IsNullOrWhiteSpace(palabra) && palabra.Length < 2)
                       throw new ArgumentException("Cada palabra del nombre debe tener al menos 2 letras.");
                }

                foreach (string palabra in palabras)
                {
                    if (!string.IsNullOrWhiteSpace(palabra) && !char.IsUpper(palabra[0]))
                        throw new ArgumentException($"Cada palabra del nombre debe iniciar con mayúscula: '{palabra}'");

                    _nombre = value.Trim();
                }
            }
        }

        public string Apellido
        {
            get { return _apellido; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El apellido no puede estar vacío");
                if (value.Length < 3 || value.Length > 50)
                    throw new ArgumentException("El apellido debe tener entre 3 y 50 caracteres");
                if (!Regex.IsMatch(value, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\s\-'\.]+$"))
                    throw new ArgumentException("El apellido contiene caracteres no válidos.");
                if (Regex.IsMatch(value, @"\s{2,}"))
                    throw new ArgumentException("El apellido no puede contener espacios múltiples.");
                string apellidoLower = value.ToLower();
                if (apellidoLower.Contains("  ") || apellidoLower.Contains("--"))
                    throw new ArgumentException("Formato de apellido incorrecto.");
                string[] apellidos = value.Split(' ');
                foreach (string apellido in apellidos)
                {
                    if (!string.IsNullOrWhiteSpace(apellido) && !char.IsUpper(apellido[0]))
                        throw new ArgumentException($"Cada apellido debe iniciar con mayúscula: '{apellido}'");
                }

                _apellido = value;
            }
        }

        public string Telefono
        {
            get { return _telefono; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El teléfono es obligatorio.");

                value = value.Trim();

                if (!Regex.IsMatch(value, @"^[23789]\d{3}-\d{4}$"))
                    throw new ArgumentException("Formato de teléfono inválido. Use: ####-#### (debe iniciar con 2, 3, 7, 8 o 9)");
                if (Regex.IsMatch(value, @"(\d)\1{6,}"))
                    throw new ArgumentException("Número de teléfono sospechoso (demasiados dígitos repetidos).");

                _telefono = value;
            }
        }

        public string Correo
        {
            get { return _correo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El correo electrónico es obligatorio.");

                value = value.Trim().ToLower();

                if (!Regex.IsMatch(value, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                    throw new ArgumentException("Formato de correo electrónico inválido.");
                if (value.Length < 6)
                    throw new ArgumentException("El correo debe tener al menos 6 caracteres.");
                if (value.Length > 100)
                    throw new ArgumentException("El correo no puede exceder 100 caracteres.");
                if (value.Contains(".."))
                    throw new ArgumentException("El correo no puede contener puntos consecutivos.");
                if (value.StartsWith(".") || value.EndsWith("."))
                    throw new ArgumentException("El correo no puede iniciar o terminar con punto.");
                if (value.Count(c => c == '@') != 1)
                    throw new ArgumentException("El correo debe contener exactamente un @.");

                string dominio = value.Split('@')[1];
                List<string> dominiosComunes = new List<string>
                {
                    "gmail.com", "hotmail.com", "outlook.com", "yahoo.com", "yahoo.es",
                    "unah.edu.hn", "unah.hn", "unitec.edu", "unitec.edu.hn", "ceutec.hn",
                    "ujcv.edu.hn", "catolica.edu.hn", "upnfm.edu.hn", "zamorano.edu",
                    "live.com", "msn.com", "icloud.com", "protonmail.com"
                };
                bool dominioConocido = dominiosComunes.Any(d => dominio.EndsWith(d));
                if (!dominioConocido && !dominio.EndsWith(".hn") && !dominio.EndsWith(".com") && !dominio.EndsWith(".edu"))
                {
                    System.Diagnostics.Debug.WriteLine($"Advertencia: Dominio poco común: {dominio}");
                }
                _correo = value;
            }
        }

        public string Direccion
        {
            get { return _direccion; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La dirección es obligatoria.");

                value = value.Trim();

                if (value.Length < 10)
                    throw new ArgumentException("La dirección debe tener al menos 10 caracteres.");
                if (value.Length > 200)
                    throw new ArgumentException("La dirección no puede exceder 200 caracteres.");
                if (!Regex.IsMatch(value, @"^[a-zA-Z0-9áéíóúÁÉÍÓÚñÑüÜ\s\-\.,#°\(\)\/]+$"))
                    throw new ArgumentException("La dirección contiene caracteres no válidos.");

                string direccionLower = value.ToLower();
                List<string> palabrasClaveHonduras = new List<string>
                {
                    "col", "colonia", "res", "residencial", "barrio", "bo", "aldea", "caserio",
                    "bloque", "casa", "avenida", "ave", "calle", "boulevard", "blvd", "anillo",
                    "sector", "zona", "etapa", "manzana", "lote", "apartamento", "apto",
                    "edificio", "edif", "torre", "nivel", "local"
                };
                bool contienePalabraClave = palabrasClaveHonduras.Any(palabra => direccionLower.Contains(palabra));
                if (!contienePalabraClave)
                    throw new ArgumentException("La dirección debe incluir referencias válidas (colonia, residencial, barrio, calle, etc.).");

                List<string> ciudadesHonduras = new List<string>
                {
                    "tegucigalpa", "san pedro sula", "choloma", "la ceiba", "el progreso",
                    "choluteca", "comayagua", "puerto cortes", "la lima", "danli",
                    "siguatepeque", "juticalpa", "villanueva", "tocoa", "catacamas",
                    "olanchito", "san lorenzo", "cofradia", "el paraiso", "la entrada",
                    "santa rosa de copan", "potrerillos", "tela", "santa barbara",
                    "comayaguela", "distrito central", "mdc", "francisco morazan", "fm"
                };

                bool contieneCiudad = ciudadesHonduras.Any(ciudad => direccionLower.Contains(ciudad));
                if (!contieneCiudad)
                {
                    System.Diagnostics.Debug.WriteLine("Advertencia: La dirección no menciona una ciudad reconocida de Honduras.");
                }
                _direccion = value;
            }
        }

        public string Identificacion
        {
            get { return _identificacion; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La identidad es obligatoria.");
                string identidadLimpia = Regex.Replace(value ?? "", @"[^\d]", "");
                if (identidadLimpia.Length != 13)
                    throw new ArgumentException("La identidad debe contener exactamente 13 dígitos numéricos.");
              /*  string codigoDepartamento = identidadLimpia.Substring(0, 2);
                Dictionary<string, string> departamentosHonduras = new Dictionary<string, string>
                {
                    {"01", "Atlántida"},
                    {"02", "Colón"},
                    {"03", "Comayagua"},
                    {"04", "Copán"},
                    {"05", "Cortés"},
                    {"06", "Choluteca"},
                    {"07", "El Paraíso"},
                    {"08", "Francisco Morazán"},
                    {"09", "Gracias a Dios"},
                    {"10", "Intibucá"},
                    {"11", "Islas de la Bahía"},
                    {"12", "La Paz"},
                    {"13", "Lempira"},
                    {"14", "Ocotepeque"},
                    {"15", "Olancho"},
                    {"16", "Santa Bárbara"},
                    {"17", "Valle"},
                    {"18", "Yoro"}
                };

                if (!departamentosHonduras.ContainsKey(codigoDepartamento))
                    throw new ArgumentException($"Código de departamento inválido: {codigoDepartamento}. Debe ser entre 01 y 18.");

                string codigoMunicipio = identidadLimpia.Substring(2, 2);
                int municipio = int.Parse(codigoMunicipio);
                if (municipio < 1 || municipio > 28)
                    throw new ArgumentException($"Código de municipio inválido: {codigoMunicipio}. Debe ser entre 01 y 28."); */

                _identificacion = value;
            }
        }
            
        public DateTime FechaNacimiento
        {
            
                get { return _fechaNacimiento; }
                set
    {
                  /*  if (value > DateTime.Now)
                        throw new ArgumentException("La fecha de nacimiento no puede ser en el futuro.");

                    if (value < new DateTime(1900, 1, 1))
                        throw new ArgumentException("La fecha de nacimiento no puede ser anterior al año 1900.");

                    int edadCalculada = DateTime.Now.Year - value.Year;
                    if (DateTime.Now < value.AddYears(edadCalculada))
                        edadCalculada--;

                    if (edadCalculada < 7)
                        throw new ArgumentException("La persona debe tener al menos 7 años de edad.");

                    if (edadCalculada > 90)
                        throw new ArgumentException("La edad no puede ser mayor a 90 años.");

                    if (!string.IsNullOrEmpty(_identificacion))
                    {
                       string identidadLimpia = Regex.Replace(_identificacion, @"[^\d]", "");
                      if (identidadLimpia.Length == 13)
                        {
                            int añoIdentidad = int.Parse(identidadLimpia.Substring(4,2));
                            if (añoIdentidad >= 0 && añoIdentidad <= 25)
                                añoIdentidad += 2000;   
                            else
                                añoIdentidad += 1900; 

                            if (añoIdentidad != value.Year)
                            {
                                throw new ArgumentException($"El año de nacimiento ({value.Year}) no coincide con la identidad ({añoIdentidad}).");
                            }
                        }
                    }

                    _fechaNacimiento = value; */
                } 
            } 

        




        public string Genero
        {
            get { return _genero; }
            set
            {
            /*   if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El género es obligatorio.");

                value = value.Trim();

                List<string> generosValidos = new List<string>
                {
                    "Masculino", "Femenino", "Otro", "No binario", "Prefiero no decir"
                };
                if (!generosValidos.Contains(value))
                {
                    throw new ArgumentException($"El género debe ser uno de: {string.Join(", ", generosValidos)}");
                }
                _genero = value;*/
            }
        }

        protected bool ValidarTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono)) return false;
            return Regex.IsMatch(telefono, @"^[23789]\d{3}-\d{4}$");
        }

        protected bool ValidarCorreo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo)) return false;
            return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        public int Edad
        {
            get
            {
                var edad = DateTime.Now.Year - _fechaNacimiento.Year;
                if (DateTime.Now.DayOfYear < _fechaNacimiento.DayOfYear)
                    edad--;
                return edad;
            }
        }

        public string NombreCompleto
        {
            get { return $"{_nombre} {_apellido}"; }
        }
    }
}