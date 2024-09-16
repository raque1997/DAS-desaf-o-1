
//DASS

namespace GestorBibliotecaVol.Properties {
    using System;
    
 
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]

    // Clase interna que gestiona los recursos de la aplicación.
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                // Si la instancia de resourceMan es nula, crea una nueva con los recursos de "GestorBibliotecaVol.Properties.Resources".
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GestorBibliotecaVol.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        ///   Obtiene o establece la cultura utilizada para buscar los recursos.  
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        internal static System.Drawing.Bitmap Los_libros_ocupan_un_lugar_muy_importante_en_la_vida_de_las_personas {
            get {
                object obj = ResourceManager.GetObject("Los-libros-ocupan-un-lugar-muy-importante-en-la-vida-de-las-personas", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
