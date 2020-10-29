using System;

namespace WixSharp
{
    /// <summary>
    /// 
    /// </summary>
    public class NetVersion
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public string PrerequisiteFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PrerequisiteRegKeyValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Condition Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ErrorMessage { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="prerequisiteFile"></param>
        /// <param name="prerequisiteRegKeyValue"></param>
        /// <param name="condition"></param>
        /// <param name="errorMessage"></param>
        public NetVersion(string prerequisiteFile, string prerequisiteRegKeyValue, Condition condition, string errorMessage)
        {
            PrerequisiteFile = prerequisiteFile ?? throw new ArgumentNullException(nameof(prerequisiteFile));
            PrerequisiteRegKeyValue = prerequisiteRegKeyValue ?? throw new ArgumentNullException(nameof(prerequisiteRegKeyValue));
            Condition = condition ?? throw new ArgumentNullException(nameof(condition));
            ErrorMessage = errorMessage ?? throw new ArgumentNullException(nameof(errorMessage));
        }

        #endregion
    }
}
