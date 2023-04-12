/*
 * These are classes that translateed from a BuildDefinition using Visual Studio "Paste from JSON"
 * 
 */

#nullable disable

#if DEBUG

#pragma warning disable IDE1006 // Naming Styles

#pragma warning disable CA1050

public class Rootobject
{
    public Option[] options { get; set; }
    public Trigger[] triggers { get; set; }
    public Variables variables { get; set; }
    public Properties properties { get; set; }
    public object[] tags { get; set; }
    public _Links _links { get; set; }
    public string jobAuthorizationScope { get; set; }
    public int jobTimeoutInMinutes { get; set; }
    public int jobCancelTimeoutInMinutes { get; set; }
    public Process process { get; set; }
    public Repository repository { get; set; }
    public string quality { get; set; }
    public Authoredby authoredBy { get; set; }
    public object[] drafts { get; set; }
    public Queue queue { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public string url { get; set; }
    public string uri { get; set; }
    public string path { get; set; }
    public string type { get; set; }
    public string queueStatus { get; set; }
    public int revision { get; set; }
    public DateTime createdDate { get; set; }
    public Project project { get; set; }
}

public class Variables
{
    public Runall runall { get; set; }
}

public class Runall
{
    public string value { get; set; }
    public bool allowOverride { get; set; }
}

public class Properties
{
}

public class _Links
{
    public Self self { get; set; }
    public Web web { get; set; }
    public Editor editor { get; set; }
    public Badge badge { get; set; }
}

public class Self
{
    public string href { get; set; }
}

public class Web
{
    public string href { get; set; }
}

public class Editor
{
    public string href { get; set; }
}

public class Badge
{
    public string href { get; set; }
}

public class Process
{
    public string yamlFilename { get; set; }
    public int type { get; set; }
}

public class Repository
{
    public Properties1 properties { get; set; }
    public string id { get; set; }
    public string type { get; set; }
    public string name { get; set; }
    public string url { get; set; }
    public string defaultBranch { get; set; }
    public object clean { get; set; }
    public bool checkoutSubmodules { get; set; }
}

public class Properties1
{
    public string cloneUrl { get; set; }
    public string fullName { get; set; }
    public string defaultBranch { get; set; }
    public string isFork { get; set; }
    public string safeRepository { get; set; }
    public string reportBuildStatus { get; set; }
    public string cleanOptions { get; set; }
    public string fetchDepth { get; set; }
    public string gitLfsSupport { get; set; }
    public string skipSyncSource { get; set; }
    public string checkoutNestedSubmodules { get; set; }
    public string labelSources { get; set; }
    public string labelSourcesFormat { get; set; }
}

public class Authoredby
{
    public string displayName { get; set; }
    public string url { get; set; }
    public _Links1 _links { get; set; }
    public string id { get; set; }
    public string uniqueName { get; set; }
    public string imageUrl { get; set; }
    public string descriptor { get; set; }
}

public class _Links1
{
    public Avatar avatar { get; set; }
}

public class Avatar
{
    public string href { get; set; }
}

public class Queue
{
    public _Links2 _links { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public string url { get; set; }
    public Pool pool { get; set; }
}

public class _Links2
{
    public Self1 self { get; set; }
}

public class Self1
{
    public string href { get; set; }
}

public class Pool
{
    public int id { get; set; }
    public string name { get; set; }
    public bool isHosted { get; set; }
}

public class Project
{
    public string id { get; set; }
    public string name { get; set; }
    public string url { get; set; }
    public string state { get; set; }
    public int revision { get; set; }
    public string visibility { get; set; }
    public DateTime lastUpdateTime { get; set; }
}

public class Option
{
    public bool enabled { get; set; }
    public Definition definition { get; set; }
    public Inputs inputs { get; set; }
}

public class Definition
{
    public string id { get; set; }
}

public class Inputs
{
    public string branchFilters { get; set; }
    public string additionalFields { get; set; }
    public string workItemType { get; set; }
    public string assignToRequestor { get; set; }
}

public class Trigger
{
    public object[] branchFilters { get; set; }
    public object[] pathFilters { get; set; }
    public int settingsSourceType { get; set; }
    public bool batchChanges { get; set; }
    public int maxConcurrentBuildsPerBranch { get; set; }
    public string triggerType { get; set; }
    public Schedule[] schedules { get; set; }
}

public class Schedule
{
    public string[] branchFilters { get; set; }
    public string timeZoneId { get; set; }
    public int startHours { get; set; }
    public int startMinutes { get; set; }
    public string daysToBuild { get; set; }
    public string scheduleJobId { get; set; }
    public bool scheduleOnlyWithChanges { get; set; }
}

#pragma warning restore CA1050

#pragma warning restore IDE1006 // Naming Styles


#endif

#nullable enable