using System.Collections.Immutable;

namespace Kentico.Community.Portal.Core.Modules;

/// <summary>
/// Taxonomies required by the system
/// </summary>
public static class SystemTaxonomies
{
    public static BlogTypeTaxonomy BlogType { get; } = new();
    public static QAndADiscussionTypeTaxonomy QAndADiscussionType { get; } = new();
    public static IntegrationTypeTaxonomy IntegrationType { get; } = new();
    public static ContentAuthorizationTaxonomy ContentAuthorization { get; } = new();

    public static readonly ImmutableList<ISystemTaxonomy> ProtectedTaxonomies =
    [
        BlogType,
        QAndADiscussionType,
        IntegrationType,
        ContentAuthorization
    ];

    public static bool Includes(TaxonomyInfo taxonomy) =>
        ProtectedTaxonomies.Select(t => t.TaxonomyGUID).Contains(taxonomy.TaxonomyGUID);

    public static bool Includes(TagInfo tag) =>
        ProtectedTaxonomies.SelectMany(t => t.ProtectedTags.Select(t => t.TagGUID)).Contains(tag.TagGUID);

    public record BlogTypeTaxonomy : ISystemTaxonomy
    {
        public static Guid GUID { get; } = new("8419874e-3ec4-4da4-8a32-263f7ba5b864");
        public const string CodeName = "BlogType";

        public Guid TaxonomyGUID => GUID;
        public string TaxonomyName => CodeName;

        public ImmutableList<ISystemTag> ProtectedTags { get; } = [];
    }
    public record IntegrationTypeTaxonomy : ISystemTaxonomy
    {
        public static Guid GUID { get; } = new("97cd2b53-499b-435c-a083-30a7dd510167");
        public const string CodeName = "IntegrationType";

        public Guid TaxonomyGUID => GUID;
        public string TaxonomyName => CodeName;

        public ImmutableList<ISystemTag> ProtectedTags { get; } = [];
    }
    public record QAndADiscussionTypeTaxonomy : ISystemTaxonomy
    {
        public static QuestionTag Question { get; } = new();
        public static BlogTag Blog { get; } = new();

        public static Guid GUID { get; } = new("0b38791a-e864-492b-b245-a6b3f3fea46c");
        public const string CodeName = "QAndADiscussionType";

        public Guid TaxonomyGUID => GUID;
        public string TaxonomyName => CodeName;

        public ImmutableList<ISystemTag> ProtectedTags { get; } =
        [
            Question,
            Blog
        ];

        public record QuestionTag : ISystemTag
        {
            public static Guid GUID { get; } = new("c50e7dd3-2b8e-47b5-96ee-3f04ccfde8b6");
            public static string CodeName { get; } = "Question";

            public Guid TagGUID => GUID;
            public string TagName => CodeName;
        }

        public record BlogTag : ISystemTag
        {
            public static Guid GUID { get; } = new("0a81201d-8daa-4a54-bcc1-320914635b8f");
            public static string CodeName { get; } = "Blog";

            public Guid TagGUID => GUID;
            public string TagName => CodeName;
        }
    }
    public record DXTopicTaxonomy : ISystemTaxonomy
    {
        public static Guid GUID { get; } = new("72f39193-9dee-45df-9138-730ed4445858");
        public const string CodeName = "DXTopic";

        public Guid TaxonomyGUID => GUID;
        public string TaxonomyName => CodeName;

        public ImmutableList<ISystemTag> ProtectedTags { get; } = [];
    }
    public record ContentAuthorizationTaxonomy : ISystemTaxonomy
    {
        public static CommunityLeaderTag CommunityLeader { get; } = new();
        public static InternalEmployeeTag InternalEmployee { get; } = new();
        public static MVPTag MVP { get; } = new();

        public static Guid GUID { get; } = new("ca9aa59d-d3fd-4f4c-bb67-5a1b3c0f5ad5");
        public const string CodeName = "ContentAuthorization";

        public Guid TaxonomyGUID => GUID;
        public string TaxonomyName => CodeName;

        public ImmutableList<ISystemTag> ProtectedTags { get; } =
        [
            CommunityLeader,
            InternalEmployee,
            MVP
        ];

        public record CommunityLeaderTag : ISystemTag
        {
            public static Guid GUID { get; } = new("63060a51-9025-46a4-a6ac-9a48fd712756");
            public static string CodeName { get; } = "CommunityLeader";

            public Guid TagGUID => GUID;
            public string TagName => CodeName;
        }
        public record InternalEmployeeTag : ISystemTag
        {
            public static Guid GUID { get; } = new("c265fa94-4982-415e-b56d-261b4f4b5b15");
            public static string CodeName { get; } = "InternalEmployee";

            public Guid TagGUID => GUID;
            public string TagName => CodeName;
        }
        public record MVPTag : ISystemTag
        {
            public static Guid GUID { get; } = new("83b28847-6c4d-40d1-9d76-4214c740c3c3");
            public static string CodeName { get; } = "MVP";

            public Guid TagGUID => GUID;
            public string TagName => CodeName;
        }
    }
}

public interface ISystemTaxonomy
{
    Guid TaxonomyGUID { get; }
    string TaxonomyName { get; }

    ImmutableList<ISystemTag> ProtectedTags { get; }
}
public interface ISystemTag
{
    Guid TagGUID { get; }
    string TagName { get; }
}
