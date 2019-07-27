﻿// <copyright file="TicketSearchScope.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace Microsoft.Teams.Apps.FAQPlusPlus.Models
{
    /// <summary>
    /// Ticket search scope
    /// </summary>
    public enum TicketSearchScope
    {
        /// <summary>
        /// Recent tickets
        /// </summary>
        RecentTickets,

        /// <summary>
        /// Open tickets
        /// </summary>
        OpenTickets,

        /// <summary>
        /// Tickets assigned to a subject-matter expert
        /// </summary>
        AssignedTickets
    }
}