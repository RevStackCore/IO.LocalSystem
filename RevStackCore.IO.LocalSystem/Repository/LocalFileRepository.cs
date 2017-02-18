using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

namespace RevStackCore.IO.LocalSystem
{
	public class LocalFileRepository : IIORepository
	{
		private readonly LocalFileDbContext _dbContext;
		public LocalFileRepository(LocalFileDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public virtual FileEntity Add(FileEntity entity)
		{
			return _dbContext.Add(entity);
		}

		public virtual void Delete(FileEntity entity)
		{
			_dbContext.Delete(entity.Path);
		}

		public virtual IQueryable<FileEntity> Find(Expression<Func<FileEntity, bool>> predicate)
		{
			return _dbContext.Get().AsQueryable().Where(predicate);
		}

		public virtual IEnumerable<FileEntity> Get()
		{
			return _dbContext.Get();
		}

		public virtual IEnumerable<FileEntity> Get(IOFileEncodingType type)
		{
			return _dbContext.Get(type);
		}

		public virtual IEnumerable<FileEntity> Get(string path, string searchPattern, SearchOption searchOption)
		{
			return _dbContext.Get(path, searchPattern, searchOption);
		}

		public virtual FileEntity GetById(string id)
		{
			return _dbContext.GetById(id);
		}

		public virtual FileEntity GetById(string id, IOFileEncodingType type)
		{
			return _dbContext.GetById(id, type);
		}

		public virtual FileEntity GetById(string id, IOFileEncodingType type, string format)
		{
			return _dbContext.GetById(id, type, format);
		}

		public virtual FileEntity GetById(string id, IOFileEncodingType type, IODataStringFormat format)
		{
			return _dbContext.GetById(id, type, format);
		}

		public virtual FileEntity Update(FileEntity entity)
		{
			return _dbContext.Update(entity);
		}
	}
}
