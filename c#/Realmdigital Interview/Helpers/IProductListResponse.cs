using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Realmdigital_Interview.Helpers
{
    public interface IProductListResponse
    {
        List<object> decodeResponse(List<ApiResponseProduct> reponseObject);
    }
}