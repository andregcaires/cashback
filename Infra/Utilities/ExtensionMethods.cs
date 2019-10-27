using System;
using System.Reflection;

namespace Utilities
{
    public static class ExtensionMethods
    {
        public static dynamic ConvertTo<T1>(this T1 source) 
        {
            var result = Activator.CreateInstance(typeof(T1));
            foreach (PropertyInfo sourceProp in source.GetType().GetProperties()) 
            {

                foreach (PropertyInfo targetProp in result.GetType().GetProperties())
                {
                    if (sourceProp.Name == targetProp.Name) { 
                        targetProp.SetValue(result, sourceProp.GetValue(source));
                    }
                }
            }

            return result;
        }
    }
}