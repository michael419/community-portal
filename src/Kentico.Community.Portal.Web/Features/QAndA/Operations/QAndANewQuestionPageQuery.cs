using CMS.ContentEngine;
using Kentico.Community.Portal.Core.Operations;

namespace Kentico.Community.Portal.Web.Features.QAndA;

public record QAndANewQuestionPageQuery(string ChannelName) : IQuery<QAndANewQuestionPage>, IChannelContentQuery;
public class QAndANewQuestionPageQueryHandler(ContentItemQueryTools tools) : ContentItemQueryHandler<QAndANewQuestionPageQuery, QAndANewQuestionPage>(tools)
{
    public override async Task<QAndANewQuestionPage> Handle(QAndANewQuestionPageQuery request, CancellationToken cancellationToken = default)
    {
        var b = new ContentItemQueryBuilder().ForContentType(QAndANewQuestionPage.CONTENT_TYPE_NAME, queryParameters =>
        {
            _ = queryParameters
                .ForWebsite(request.ChannelName)
                .TopN(1);
        });

        var pages = await Executor.GetMappedWebPageResult<QAndANewQuestionPage>(b, DefaultQueryOptions, cancellationToken);

        return pages.First();
    }

    protected override ICacheDependencyKeysBuilder AddDependencyKeys(QAndANewQuestionPageQuery query, QAndANewQuestionPage result, ICacheDependencyKeysBuilder builder) =>
        builder.AllContentItems(QAndANewQuestionPage.CONTENT_TYPE_NAME);
}
