using RegerBiblioteca.App.Models.Reservas;
using RegerBiblioteca.App.Services.Interfaces;
using RegerBiblioteca.Core.Repositories;

namespace RegerBiblioteca.App.Services
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaService(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        public ResultViewModel<int> Create(CreateReservaInputModel model)
        {
            var reserva = new Core.Entities.Reserva
            {
                FuncionarioId = model.FuncionarioId,
                UsuarioId = model.UsuarioId,
                ExemplarId = model.ExemplarId,
                DataReserva = model.DataReserva,
                Status = model.Status
            };

            var reservaId = _reservaRepository.Insert(reserva);

            if(reservaId <= 0)
            {
                return ResultViewModel<int>.Error("Erro ao criar reserva.");
            }

            return ResultViewModel<int>.Success(reservaId);
        }
        
        public ResultViewModel Update(int id, UpdateReservaInputModel model)
        {
            var reserva = _reservaRepository.GetById(id);

            if (reserva is null)
                return ResultViewModel.Error("Reserva não encontrada.");

            reserva.FuncionarioId = model.FuncionarioId;
            reserva.UsuarioId = model.UsuarioId;
            reserva.ExemplarId = model.ExemplarId;
            reserva.DataReserva = model.DataReserva;
            reserva.Status = model.Status;

            _reservaRepository.Update(reserva);

            return ResultViewModel.Success();
        }

        public ResultViewModel Delete(int id)
        {
            var reserva = _reservaRepository.GetById(id);

            if (reserva is null)
                return ResultViewModel.Error("Reserva não encontrada.");

            _reservaRepository.Delete(reserva);

            return ResultViewModel.Success();
        }
        
        public ResultViewModel<ReservaViewModel?> GetById(int id)
        {
            var reserva = _reservaRepository.GetById(id);

            return reserva is null 
                ? ResultViewModel<ReservaViewModel?>.Error("Reserva não encontrada.")
                : ResultViewModel<ReservaViewModel?>.Success(ReservaViewModel.FromEntity(reserva));
        }

        public ResultViewModel<List<ReservaViewModel?>> GetAll()
        {
            var listaReservas = _reservaRepository.GetAll();

            var lista = listaReservas
                .Select(r => ReservaViewModel.FromEntity(r))
                .ToList();

            return ResultViewModel<List<ReservaViewModel?>>.Success(lista);
        }

    }
}
