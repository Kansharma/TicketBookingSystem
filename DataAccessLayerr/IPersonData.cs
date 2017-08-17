using Apttus.Assignment.PersonLibrary;
using System.Collections.Generic;

namespace Apttus.Assignment.DataAccessLayerr
{
    interface IPersonData
    {
        Dictionary<string,IPerson> GetDetails();
    }
}
