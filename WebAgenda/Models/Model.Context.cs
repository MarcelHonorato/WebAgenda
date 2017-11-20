﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAgenda.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class webAgendaEntities : DbContext
    {
        public webAgendaEntities()
            : base("name=webAgendaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_event> tb_event { get; set; }
    
        public virtual ObjectResult<sp_listEvents_Result> sp_listEvents(string eventName, string eventType, Nullable<System.DateTime> eventStartDate, Nullable<System.DateTime> eventEndDate)
        {
            var eventNameParameter = eventName != null ?
                new ObjectParameter("eventName", eventName) :
                new ObjectParameter("eventName", typeof(string));
    
            var eventTypeParameter = eventType != null ?
                new ObjectParameter("eventType", eventType) :
                new ObjectParameter("eventType", typeof(string));
    
            var eventStartDateParameter = eventStartDate.HasValue ?
                new ObjectParameter("eventStartDate", eventStartDate) :
                new ObjectParameter("eventStartDate", typeof(System.DateTime));
    
            var eventEndDateParameter = eventEndDate.HasValue ?
                new ObjectParameter("eventEndDate", eventEndDate) :
                new ObjectParameter("eventEndDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_listEvents_Result>("sp_listEvents", eventNameParameter, eventTypeParameter, eventStartDateParameter, eventEndDateParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_alterEvent(Nullable<int> eventId, string eventName, string eventDesc, Nullable<System.DateTime> eventDate)
        {
            var eventIdParameter = eventId.HasValue ?
                new ObjectParameter("eventId", eventId) :
                new ObjectParameter("eventId", typeof(int));
    
            var eventNameParameter = eventName != null ?
                new ObjectParameter("eventName", eventName) :
                new ObjectParameter("eventName", typeof(string));
    
            var eventDescParameter = eventDesc != null ?
                new ObjectParameter("eventDesc", eventDesc) :
                new ObjectParameter("eventDesc", typeof(string));
    
            var eventDateParameter = eventDate.HasValue ?
                new ObjectParameter("eventDate", eventDate) :
                new ObjectParameter("eventDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_alterEvent", eventIdParameter, eventNameParameter, eventDescParameter, eventDateParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_createEvent(string eventName, string eventDesc, Nullable<System.DateTime> eventDate)
        {
            var eventNameParameter = eventName != null ?
                new ObjectParameter("eventName", eventName) :
                new ObjectParameter("eventName", typeof(string));
    
            var eventDescParameter = eventDesc != null ?
                new ObjectParameter("eventDesc", eventDesc) :
                new ObjectParameter("eventDesc", typeof(string));
    
            var eventDateParameter = eventDate.HasValue ?
                new ObjectParameter("eventDate", eventDate) :
                new ObjectParameter("eventDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_createEvent", eventNameParameter, eventDescParameter, eventDateParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_deleteEvent(Nullable<int> eventId)
        {
            var eventIdParameter = eventId.HasValue ?
                new ObjectParameter("eventId", eventId) :
                new ObjectParameter("eventId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_deleteEvent", eventIdParameter);
        }
    }
}
