using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WebApplication1.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    /// 
    /// </summary>
    public class EnumTypeModelDescription : ModelDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }
        /// <summary>
        /// 
        /// </summary>
        public Collection<EnumValueDescription> Values { get; private set; }
    }
}