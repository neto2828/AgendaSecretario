using System;
using AgendaSecretario.Models;

namespace AgendaSecretario.Class
{
    public interface IAgendaCollection
    {
        void InsertAgenda(Agenda agenda);
        void UpdateAgenda(Agenda agenda);
        void DeleteAgenda(String id);
        void PublishAgenda(String id);
        List<Agenda> GetAllAgenda();
        Agenda GetAgendaById(string id);
        void Publicado(Agenda agenda);
    }
}

