using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realmdigital_Interview.Helpers
{
    public interface ISingleProductResponse
    {
        object decodeResponse(List<ApiResponseProduct> reponseObject);
        
    }
}
