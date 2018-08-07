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
    public class PageVersionSummary : ICreateAudited
    {
        /// <summary>
        /// Database id of this page version.
        /// </summary>
        public int PageVersionId { get; set; }

        public string Title { get; set; }

        /// <summary>
        /// Indicates whether the page should show in the autogenerated site map
        /// that gets presented to search engine robots.
        /// </summary>
        public bool ShowInSiteMap { get; set; }

        /// <summary>
        /// A page can have many published versions, this flag indicates if
        /// it is the latest published version which displays on the live site
        /// when the page itself is published.
        /// </summary>
        public bool IsLatestPublishedVersion { get; set; }

        /// <summary>
        /// The workflow state of this version e.g. draft/published.
        /// </summary>
        public WorkFlowStatus WorkFlowStatus { get; set; }

        public PageTemplateMicroSummary Template { get; set; }
        
        public CreateAuditData AuditData { get; set; }
    }
}
