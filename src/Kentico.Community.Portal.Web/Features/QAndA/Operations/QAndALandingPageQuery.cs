using CMS.ContentEngine;
using Kentico.Community.Portal.Core.Operations;

namespace Kentico.Community.Portal.Web.Features.QAndA;

public record QAndALandingPageQuery(string ChannelName) : IQuery<QAndALandingPage>, IChannelContentQuery;
public class QAndALandingPageQueryHandler(ContentItemQueryTools tools) : ContentItemQueryHandler<QAndALandingPageQuery, QAndALandingPage>(tools)
{
    public override async Task<QAndALandingPage> Handle(QAndALandingPageQuery request, CancellationToken cancellationToken = default)
    {
        var b = new ContentItemQueryBuilder().ForContentType(QAndALandingPage.CONTENT_TYPE_NAME, queryParameters =>
        {
            _ = queryParameters
                .ForWebsite(request.ChannelName)
                .TopN(1);
        });

        var pages = await Executor.GetMappedWebPageResult<QAndALandingPage>(b, DefaultQueryOptions, cancellationToken);

        return pages.First();
    }

    protected override ICacheDependencyKeysBuilder AddDependencyKeys(QAndALandingPageQuery query, QAndALandingPage result, ICacheDependencyKeysBuilder builder) =>
        builder.AllContentItems(QAndALandingPage.CONTENT_TYPE_NAME);
}
