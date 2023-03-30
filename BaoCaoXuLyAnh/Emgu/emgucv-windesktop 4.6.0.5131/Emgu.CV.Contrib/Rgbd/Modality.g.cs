//----------------------------------------------------------------------------
//  This file is automatically generated, do not modify.      
//----------------------------------------------------------------------------



using System;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Emgu.CV.Linemod
{
   public static partial class LinemodInvoke
   {

     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern void cveModalityName(IntPtr obj, IntPtr str);
     
   }

   public partial class Modality
   {

     /// <summary>
     /// The name of modality
     /// </summary>
     public String Name
     {
        get 
        { 
           using (CvString s = new CvString())
           {  
              LinemodInvoke.cveModalityName(_ptr, s); 
              return s.ToString();
           }
        } 
     }
     
   }
}
