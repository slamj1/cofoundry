﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofoundry.Domain
{
    /// <summary>
    /// Contains version specific information about a page. This includes
    /// basic audit data intended for use in the admin area.
    /// </summary>
    public class PageVersionDetails : ICreateAudited
    {
        /// <summary>
        /// Database id of this page version.
        /// </summary>
        public int PageVersionId { get; set; }

        /// <summary>
        /// The descriptive human-readable title of page that is often 
        /// used in the html page title meta tag. Does not have to be
        /// unique.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Indicates whether the page should show in the autogenerated site map
        /// that gets presented to search engine robots.
        /// </summary>
        public bool ShowInSiteMap { get; set; }

        /// <summary>
        /// The description of the content of the page. This is intended to
        /// be used in the description html meta tag.
        /// </summary>
        public string MetaDescription { get; set; }

        public OpenGraphData OpenGraph { get; set; }

        /// <summary>
        /// The workflow state of this version e.g. draft/published.
        /// </summary>
        public WorkFlowStatus WorkFlowStatus { get; set; }

        /// <summary>
        /// The template used to render this page.
        /// </summary>
        public PageTemplateMicroSummary Template { get; set; }

        /// <summary>
        /// Content-editable page region and block data. The block
        /// data includes the block data model but not mapped display 
        /// models and is therefore not suited to rendering.
        /// </summary>
        public ICollection<PageRegionDetails> Regions { get; set; }

        /// <summary>
        /// Simple audit data for this instance.
        /// </summary>
        public CreateAuditData AuditData { get; set; }
    }
}
