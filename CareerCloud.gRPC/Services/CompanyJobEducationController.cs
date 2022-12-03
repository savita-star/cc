using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CareerCloud.gRPC.Protos.CompanyJobEducationService;

namespace CareerCloud.gRPC.Services
{
    public class CompanyJobEducationController : CompanyJobEducationServiceBase
    {
        private readonly CompanyJobEducationLogic _logic;

        public CompanyJobEducationController()
        {
            _logic = new CompanyJobEducationLogic(new EFGenericRepository<CompanyJobEducationPoco>());
        }

        public override Task<Empty> AddCompanyJobEducation(CompanyJobEducations request, ServerCallContext context)
        {
            List<CompanyJobEducationPoco> pocos = new List<CompanyJobEducationPoco>();
            foreach (var item in request.CompJobEdu)
            {
                pocos.Add(TranslateFrom(item));

            }
            _logic.Add(pocos.ToArray());

            return Task.FromResult<Empty>(null);
        }
        private CompanyJobEducationPoco TranslateFrom(CompanyJobEducation proto)
        {
            return new CompanyJobEducationPoco()
            {
                Id = Guid.Parse(proto.Id),
                Job = Guid.Parse(proto.Job),
                Importance = (short)proto.Importance,
                Major = proto.Major
            };
        }

        public override Task<Empty> UpdateCompanyJobEducation(CompanyJobEducations request, ServerCallContext context)
        {
            List<CompanyJobEducationPoco> pocos = new List<CompanyJobEducationPoco>();
            foreach (var item in request.CompJobEdu)
            {
                pocos.Add(TranslateFrom(item));

            }
            _logic.Update(pocos.ToArray());

            return Task.FromResult<Empty>(null);
        }
        public override Task<Empty> DeleteCompanyJobEducation(CompanyJobEducations request, ServerCallContext context)
        {
            List<CompanyJobEducationPoco> pocos = new List<CompanyJobEducationPoco>();
            foreach (var item in request.CompJobEdu)
            {
                pocos.Add(TranslateFrom(item));

            }
            _logic.Delete(pocos.ToArray());

            return Task.FromResult<Empty>(null);
        }
        public override Task<CompanyJobEducations> GetCompanyJobEducations(Empty request, ServerCallContext context)
        {
            List<CompanyJobEducation> protos = new List<CompanyJobEducation>();
            foreach (var item in _logic.GetAll())
            {
                protos.Add(TranslateTo(item));
            }
            CompanyJobEducations appEdus = new CompanyJobEducations();
            appEdus.CompJobEdu.AddRange(protos);
            return new Task<CompanyJobEducations>(() => appEdus);
        }
        public override Task<CompanyJobEducation> GetCompanyJobEducation(CompanyJobEducationIdRequest request, ServerCallContext context)
        {
            Guid id = Guid.Parse(request.Id);
            return new Task<CompanyJobEducation>(() => TranslateTo(_logic.Get(id)));
        }

        private CompanyJobEducation TranslateTo(CompanyJobEducationPoco poco)
        {

            return new CompanyJobEducation()
            {
                Id = poco.Id.ToString(),
                Job = poco.Job.ToString(),
                Importance = poco.Importance,
                Major = poco.Major
            };
        }
    }
}
