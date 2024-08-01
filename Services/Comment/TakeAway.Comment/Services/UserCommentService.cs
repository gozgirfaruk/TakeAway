using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TakeAway.Comment.Dal.Context;
using TakeAway.Comment.Dal.Entities;
using TakeAway.Comment.Dtos;

namespace TakeAway.Comment.Services
{
    public class UserCommentService : IUserCommentService
    {
        private readonly CommentContext _commentContext;
        private readonly IMapper _mapper;

        public UserCommentService(CommentContext commentContext, IMapper mapper)
        {
            _commentContext = commentContext;
            _mapper = mapper;
        }

        public async Task CreateUserCommentAsync(CreateUserCommentDto userCommentDto)
        {
            await _commentContext.UserComments.AddAsync(_mapper.Map<UserComment>(userCommentDto));
            await _commentContext.SaveChangesAsync();
        }

        public async Task DeleteUserCommentAsync(int id)
        {
            var values = await _commentContext.UserComments.FindAsync(id);
             _commentContext.UserComments.Remove(values);
            await _commentContext.SaveChangesAsync();
        }

        public async Task<List<ResultUserCommentDto>> GetAllUserCommentAsync()
        {
            var values = await _commentContext.UserComments.ToListAsync();
            return _mapper.Map<List<ResultUserCommentDto>>(values); 
        }

        public async Task<GetByIdUserCommentDto> GetByIdUserCommentAsync(int id)
        {
            var values =await _commentContext.UserComments.FindAsync(id);
            return _mapper.Map<GetByIdUserCommentDto>(values);
        }

        public async Task<List<ResultUserCommentDto>> GetProductCommentUserAsync(string productId)
        {
            var values = await _commentContext.UserComments.FindAsync(productId);
            return _mapper.Map<List<ResultUserCommentDto>>(values);
        }

        public async Task UpdateUserCommentAsync(UpdateUserCommentDto userCommentDto)
        {
             _commentContext.UserComments.Update(_mapper.Map<UserComment>(userCommentDto));
            await _commentContext.SaveChangesAsync();
        }
    }
}
