﻿using Application.DTOs.Respponces;
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Operations.Clients.Commands
{
    public class DeleteClientCommand : IRequest
    {
        public int Id { get; set; }

        public class DeleteClientHandler : IRequestHandler<DeleteClientCommand>
        {
            private readonly IServiceStationDContext _context;

            public DeleteClientHandler(IServiceStationDContext context)
            {
                _context = context;
            }
            async Task IRequestHandler<DeleteClientCommand>.Handle(DeleteClientCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Clients
                    .FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Client), request.Id);
                }

                _context.Clients.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

            }


        }
    }
}
