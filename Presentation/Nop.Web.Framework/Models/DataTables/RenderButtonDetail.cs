﻿namespace Nop.Web.Framework.Models.DataTables
{
    /// <summary>
    /// Represents button edit render for DataTables column
    /// </summary>
    public partial class RenderButtonDetail : IRender
    {
        #region Ctor

        /// <summary>
        /// Initializes a new instance of the RenderButtonDetail class 
        /// </summary>
        /// <param name="url">URL to the edit action</param>
        public RenderButtonDetail(DataUrl url)
        {
            Url = url;
            ClassName = NopButtonClassDefaults.Default;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets Url to action edit
        /// </summary>
        public DataUrl Url { get; set; }

        /// <summary>
        /// Gets or sets button class name
        /// </summary>
        public string ClassName { get; set; }

        #endregion
    }
}