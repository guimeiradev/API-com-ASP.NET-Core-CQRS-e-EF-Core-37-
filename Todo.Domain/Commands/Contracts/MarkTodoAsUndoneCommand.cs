﻿using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Commands.Contracts
{
    public class MarkTodoAsUnDoneCommand : Notifiable, ICommand
    {
        public MarkTodoAsUnDoneCommand()
        {

        }

        public MarkTodoAsUnDoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid Id { get; set; }
        public string User { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(User, 6, "User", "Usuário inválido!")
                );
        }
    }
}
