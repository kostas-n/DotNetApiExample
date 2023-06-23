using System.Threading;
using System.Threading.Tasks;

namespace SurveyExample.Common
{
	public interface IUnitOfWork
	{
		Task<int> CommitAsync(CancellationToken cancellationToken = default);
	}
}
