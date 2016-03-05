using System.Collections.Generic;
using Hsp.GenericFramework.Commons.Dtos.Models;

namespace Hsp.GenericFramework.IServices.IServices
{
    public interface ILoopkupService
    {
        List<LoopkupModel> LoadLoppkups();
    }
}
