using BookStore.Infrastructure.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.Mappers
{
    public static class ClientMapper
    {
        public static ClientViewModel Map(ClientEntity entity)
        {
            var viewModel = new ClientViewModel
            {
                id = entity.id,
                fio = entity.fio,
                dataRozd = entity.dataRozd,
                numberBooks = entity.numberBooks,
                placeInTop = entity.placeInTop,
                gender = entity.gender,
                
            };
            return viewModel;
        }

        public static List<ClientViewModel> Map(List<ClientEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
        public static ClientEntity Map(ClientViewModel viewModel)
        {
            var entity = new ClientEntity
            {
                id = viewModel.id,
                fio = viewModel.fio,
                dataRozd = viewModel.dataRozd,
                numberBooks = viewModel.numberBooks,
                placeInTop = viewModel.placeInTop,
                gender = viewModel.gender,
            };
            return entity;
        }

    }
}
