using System;

using R5T.T0110;
using R5T.T0110.I0001;


namespace System
{
    public static class ILibraryDescriptionExtensions
    {
        public static string LocalData(this ILibraryDescription _)
        {
            return LibraryDescriptions.LocalData;
        }
    }
}
