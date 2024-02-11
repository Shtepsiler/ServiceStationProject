using AutoMapper;
using ClientPartBLL.DTO.Requests;
using ClientPartBLL.DTO.Responses;
using ClientPartBLL.Services.Interfaces;
using ClientPartDAL.Entities;
using ClientPartDAL.Repositories.Contracts;

namespace ClientPartBLL.Services
{
    public class ModelService : IModelService
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _maper;

        public ModelService(IUnitOfWork unitOfWork, IMapper maper)
        {
            _unitOfWork = unitOfWork;
            _maper = maper;
        }

        public async Task<IEnumerable<ModelResponse>> GetAllAsync()
        {
            try
            {
                var results = (List<Model>)await _unitOfWork._ModelRepository.GetAsync();
                return _maper.Map<List<Model>, List<ModelResponse>>(results);
                ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ModelResponse> GetByIdAsync(int id)
        {
            try
            {
                var result = await _unitOfWork._ModelRepository.GetByIdAsync(id);
                if (result == null)
                {
                    return null;
                }
                else
                {
                    return _maper.Map<Model, ModelResponse>(result);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task PostAsync(ModelRequest Model)
        {
            try
            {

                await _unitOfWork._ModelRepository.InsertAsync(_maper.Map<ModelRequest, Model>(Model));
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateAsync(int id, ModelRequest Model)
        {

            try
            {


                var event_entity = await _unitOfWork._ModelRepository.GetByIdAsync(id);
                if (event_entity == null)
                {

                }

                await _unitOfWork._ModelRepository.UpdateAsync(_maper.Map<ModelRequest, Model>(Model));
                await _unitOfWork.SaveChangesAsync();

            }
            catch (Exception ex)
            {

            }
        }


        public async Task DeleteByIdAsync(int id)
        {
            try
            {
                var event_entity = await _unitOfWork._ModelRepository.GetByIdAsync(id);
                if (event_entity == null)
                {

                }

                await _unitOfWork._ModelRepository.DeleteAsync(id);
                await _unitOfWork.SaveChangesAsync();

            }
            catch (Exception ex)
            {

            }
        }


    }
}
