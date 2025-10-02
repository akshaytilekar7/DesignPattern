namespace CoreWebApi;

public class FeatureFlagService : IFeatureFlagService
{
    public bool IsFeatureEnabled(string featureName)
    {
        return featureName == FeatureToggleName.F2;
    }
}


public static class FeatureToggleName
{
    public const string F1 = "F1";
    public const string F2 = "F2";
    public const string F3 = "F3";
}


public interface IFeatureFlagService
{
    bool IsFeatureEnabled(string featureName);
}
