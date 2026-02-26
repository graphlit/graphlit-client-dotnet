# Graphlit .NET SDK Reference

This is the complete API reference for the Graphlit .NET SDK (`GraphlitClient`).

Uses StrawberryShake GraphQL client. All operations use `ExecuteAsync`.


## Setup

```csharp
using GraphlitClient;
using StrawberryShake;

using var httpClient = new HttpClient();
var client = new Graphlit(httpClient);
```

## Operations

### CountAlerts

Counts alerts based on the provided filter criteria.

```csharp
var response = await client.CountAlerts.ExecuteAsync(AlertFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountAlerts;
```

### CreateAlert

Creates a new alert.

```csharp
var response = await client.CreateAlert.ExecuteAsync(AlertInput alert, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CreateAlert;
```

### DeleteAlert

Deletes an alert.

```csharp
var response = await client.DeleteAlert.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteAlert;
```

### DeleteAlerts

Bulk deletes alerts.

```csharp
var response = await client.DeleteAlerts.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteAlerts;
```

### DeleteAllAlerts

Bulk deletes alerts based on the provided filter criteria.

```csharp
var response = await client.DeleteAllAlerts.ExecuteAsync(
    AlertFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllAlerts;
```

### DisableAlert

Disables an alert.

```csharp
var response = await client.DisableAlert.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DisableAlert;
```

### EnableAlert

Enables an alert.

```csharp
var response = await client.EnableAlert.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.EnableAlert;
```

### GetAlert

```csharp
var response = await client.GetAlert.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetAlert;
```

### QueryAlerts

```csharp
var response = await client.QueryAlerts.ExecuteAsync(AlertFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryAlerts;
```

### UpdateAlert

Updates an existing alert.

```csharp
var response = await client.UpdateAlert.ExecuteAsync(AlertUpdateInput alert);
response.EnsureNoErrors();
var result = response.Data?.UpdateAlert;
```

### UpsertAlert

Upserts a alert.

```csharp
var response = await client.UpsertAlert.ExecuteAsync(AlertInput alert);
response.EnsureNoErrors();
var result = response.Data?.UpsertAlert;
```

### CountCategories

Counts categories based on the provided filter criteria.

```csharp
var response = await client.CountCategories.ExecuteAsync(CategoryFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountCategories;
```

### CreateCategory

Creates a new category.

```csharp
var response = await client.CreateCategory.ExecuteAsync(CategoryInput category);
response.EnsureNoErrors();
var result = response.Data?.CreateCategory;
```

### DeleteAllCategories

Bulk deletes categories based on the provided filter criteria.

```csharp
var response = await client.DeleteAllCategories.ExecuteAsync(
    CategoryFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllCategories;
```

### DeleteCategories

Bulk deletes categories.

```csharp
var response = await client.DeleteCategories.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteCategories;
```

### DeleteCategory

Deletes a category.

```csharp
var response = await client.DeleteCategory.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteCategory;
```

### GetCategory

```csharp
var response = await client.GetCategory.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetCategory;
```

### QueryCategories

```csharp
var response = await client.QueryCategories.ExecuteAsync(CategoryFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryCategories;
```

### UpdateCategory

Updates a category.

```csharp
var response = await client.UpdateCategory.ExecuteAsync(CategoryUpdateInput category);
response.EnsureNoErrors();
var result = response.Data?.UpdateCategory;
```

### UpsertCategory

Upserts a category.

```csharp
var response = await client.UpsertCategory.ExecuteAsync(CategoryInput category);
response.EnsureNoErrors();
var result = response.Data?.UpsertCategory;
```

### AddContentsToCollections

Adds contents to one or more collections.

```csharp
var response = await client.AddContentsToCollections.ExecuteAsync(
    IReadOnlyList<EntityReferenceInput> contents,
    IReadOnlyList<EntityReferenceInput> collections
);
response.EnsureNoErrors();
var result = response.Data?.AddContentsToCollections;
```

### AddConversationsToCollections

```csharp
var response = await client.AddConversationsToCollections.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.AddConversationsToCollections;
```

### CountCollections

Counts collections based on the provided filter criteria.

```csharp
var response = await client.CountCollections.ExecuteAsync(CollectionFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountCollections;
```

### CreateCollection

Creates a new collection.

```csharp
var response = await client.CreateCollection.ExecuteAsync(CollectionInput collection);
response.EnsureNoErrors();
var result = response.Data?.CreateCollection;
```

### DeleteAllCollections

Bulk deletes collections based on the provided filter criteria.

```csharp
var response = await client.DeleteAllCollections.ExecuteAsync(
    CollectionFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllCollections;
```

### DeleteCollection

Deletes a collection.

```csharp
var response = await client.DeleteCollection.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteCollection;
```

### DeleteCollections

Bulk deletes collections.

```csharp
var response = await client.DeleteCollections.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteCollections;
```

### GetCollection

```csharp
var response = await client.GetCollection.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetCollection;
```

### QueryCollections

```csharp
var response = await client.QueryCollections.ExecuteAsync(CollectionFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryCollections;
```

### RemoveContentsFromCollection

Removes contents from a collection.

```csharp
var response = await client.RemoveContentsFromCollection.ExecuteAsync(
    IReadOnlyList<EntityReferenceInput> contents,
    EntityReferenceInput collection
);
response.EnsureNoErrors();
var result = response.Data?.RemoveContentsFromCollection;
```

### RemoveConversationsFromCollection

```csharp
var response = await client.RemoveConversationsFromCollection.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.RemoveConversationsFromCollection;
```

### UpdateCollection

Updates an existing collection.

```csharp
var response = await client.UpdateCollection.ExecuteAsync(CollectionUpdateInput collection);
response.EnsureNoErrors();
var result = response.Data?.UpdateCollection;
```

### CountConnectors

Counts connectors based on the provided filter criteria.

```csharp
var response = await client.CountConnectors.ExecuteAsync(ConnectorFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountConnectors;
```

### CreateConnector

Creates a new connector.

```csharp
var response = await client.CreateConnector.ExecuteAsync(ConnectorInput connector);
response.EnsureNoErrors();
var result = response.Data?.CreateConnector;
```

### DeleteConnector

Deletes a connector.

```csharp
var response = await client.DeleteConnector.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteConnector;
```

### GetConnector

```csharp
var response = await client.GetConnector.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetConnector;
```

### QueryConnectors

```csharp
var response = await client.QueryConnectors.ExecuteAsync(ConnectorFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryConnectors;
```

### UpdateConnector

Updates an existing connector.

```csharp
var response = await client.UpdateConnector.ExecuteAsync(ConnectorUpdateInput connector);
response.EnsureNoErrors();
var result = response.Data?.UpdateConnector;
```

### ApproveContent

```csharp
var response = await client.ApproveContent.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.ApproveContent;
```

### CountContents

Counts contents based on the provided filter criteria.

```csharp
var response = await client.CountContents.ExecuteAsync(ContentFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountContents;
```

### DeleteAllContents

Bulk deletes content based on the provided filter criteria.

```csharp
var response = await client.DeleteAllContents.ExecuteAsync(
    ContentFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllContents;
```

### DeleteContent

Deletes content.

```csharp
var response = await client.DeleteContent.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteContent;
```

### DeleteContents

Deletes multiple contents given their IDs.

```csharp
var response = await client.DeleteContents.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteContents;
```

### DescribeEncodedImage

Describes Base64-encoded image using LLM via prompt.

```csharp
var response = await client.DescribeEncodedImage.ExecuteAsync(
    string prompt,
    string mimeType,
    string data,
    EntityReferenceInput? specification,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DescribeEncodedImage;
```

### DescribeImage

Describes image using LLM via prompt.

```csharp
var response = await client.DescribeImage.ExecuteAsync(
    string prompt,
    Uri uri,
    EntityReferenceInput? specification,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DescribeImage;
```

### DistributeContents

```csharp
var response = await client.DistributeContents.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.DistributeContents;
```

### ExtractContents

Extracts data using tool calling, from contents resulting from the provided filter criteria.

```csharp
var response = await client.ExtractContents.ExecuteAsync(
    string prompt,
    ContentFilter? filter,
    EntityReferenceInput? specification,
    IReadOnlyList<ToolDefinitionInput> tools,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.ExtractContents;
```

### ExtractObservables

Extracts observable entities from text.

```csharp
var response = await client.ExtractObservables.ExecuteAsync(
    string text,
    TextTypes? textType,
    EntityReferenceInput? specification,
    IReadOnlyList<ObservableTypes>? observableTypes,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.ExtractObservables;
```

### ExtractText

Extracts data using tool calling, from text.

```csharp
var response = await client.ExtractText.ExecuteAsync(
    string prompt,
    string text,
    TextTypes? textType,
    EntityReferenceInput? specification,
    IReadOnlyList<ToolDefinitionInput> tools,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.ExtractText;
```

### GetContent

```csharp
var response = await client.GetContent.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetContent;
```

### IngestBatch

Ingests a batch of content by URI. Supports files and webpages.

```csharp
var response = await client.IngestBatch.ExecuteAsync(
    IReadOnlyList<Uri> uris,
    EntityReferenceInput? workflow,
    IReadOnlyList<EntityReferenceInput>? collections,
    IReadOnlyList<ObservationReferenceInput>? observations,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.IngestBatch;
```

### IngestEncodedFile

Ingests a file from Base64-encoded data.

```csharp
var response = await client.IngestEncodedFile.ExecuteAsync(
    string name,
    string data,
    string mimeType,
    string? id,
    string? identifier,
    DateTimeOffset? fileCreationDate,
    DateTimeOffset? fileModifiedDate,
    bool? isSynchronous,
    IReadOnlyList<EntityReferenceInput>? collections,
    IReadOnlyList<ObservationReferenceInput>? observations,
    EntityReferenceInput? workflow,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.IngestEncodedFile;
```

### IngestEvent

Ingests calendar event.

```csharp
var response = await client.IngestEvent.ExecuteAsync(
    string markdown,
    string? name,
    string? description,
    DateTimeOffset? eventDate,
    string? id,
    string? identifier,
    IReadOnlyList<EntityReferenceInput>? collections,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.IngestEvent;
```

### IngestMemory

Ingests user or agent memory.

```csharp
var response = await client.IngestMemory.ExecuteAsync(
    string text,
    string? name,
    TextTypes? textType,
    string? id,
    string? identifier,
    IReadOnlyList<EntityReferenceInput>? collections,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.IngestMemory;
```

### IngestText

Ingests text.

```csharp
var response = await client.IngestText.ExecuteAsync(
    string text,
    string? name,
    TextTypes? textType,
    Uri? uri,
    string? id,
    string? identifier,
    bool? isSynchronous,
    EntityReferenceInput? workflow,
    IReadOnlyList<EntityReferenceInput>? collections,
    IReadOnlyList<ObservationReferenceInput>? observations,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.IngestText;
```

### IngestTextBatch

```csharp
var response = await client.IngestTextBatch.ExecuteAsync(
    IReadOnlyList<TextContentInput> batch,
    TextTypes? textType,
    EntityReferenceInput? workflow,
    IReadOnlyList<EntityReferenceInput>? collections,
    IReadOnlyList<ObservationReferenceInput>? observations,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.IngestTextBatch;
```

### IngestUri

Ingests content by URI. Supports files and webpages.

```csharp
var response = await client.IngestUri.ExecuteAsync(
    string? name,
    Uri uri,
    string? id,
    string? mimeType,
    string? identifier,
    bool? isSynchronous,
    EntityReferenceInput? workflow,
    IReadOnlyList<EntityReferenceInput>? collections,
    IReadOnlyList<ObservationReferenceInput>? observations,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.IngestUri;
```

### IsContentDone

Returns if ingested content has finished (or errored).

```csharp
var response = await client.IsContentDone.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.IsContentDone;
```

### LookupContents

Lookup multiple contents given their IDs.

```csharp
var response = await client.LookupContents.ExecuteAsync(IReadOnlyList<string> ids, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.LookupContents;
```

### LookupEntity

Lookup entity relationships via direct Gremlin traversal.

```csharp
var response = await client.LookupEntity.ExecuteAsync(EntityRelationshipsFilter filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.LookupEntity;
```

### PublishContents

Publish contents based on the provided filter criteria into different content format.

```csharp
var response = await client.PublishContents.ExecuteAsync(
    string? summaryPrompt,
    string publishPrompt,
    ContentPublishingConnectorInput connector,
    ContentFilter? filter,
    bool? includeDetails,
    bool? isSynchronous,
    string? correlationId,
    string? name,
    EntityReferenceInput? summarySpecification,
    EntityReferenceInput? publishSpecification,
    EntityReferenceInput? workflow
);
response.EnsureNoErrors();
var result = response.Data?.PublishContents;
```

### PublishText

Publish text into different content format.

```csharp
var response = await client.PublishText.ExecuteAsync(
    string text,
    TextTypes? textType,
    ContentPublishingConnectorInput connector,
    bool? isSynchronous,
    string? correlationId,
    string? name,
    EntityReferenceInput? workflow
);
response.EnsureNoErrors();
var result = response.Data?.PublishText;
```

### QueryContents

```csharp
var response = await client.QueryContents.ExecuteAsync(ContentFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryContents;
```

### QueryContentsFacets

```csharp
var response = await client.QueryContentsFacets.ExecuteAsync(
    ContentFilter? filter,
    IReadOnlyList<ContentFacetInput>? facets,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryContentsFacets;
```

### QueryContentsGraph

```csharp
var response = await client.QueryContentsGraph.ExecuteAsync(
    ContentFilter? filter,
    ContentGraphInput? graph,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryContentsGraph;
```

### QueryContentsObservations

```csharp
var response = await client.QueryContentsObservations.ExecuteAsync(ContentFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryContentsObservations;
```

### QueryGraph

```csharp
var response = await client.QueryGraph.ExecuteAsync(GraphFilter? filter, GraphInput? graph, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryGraph;
```

### QueryObservables

```csharp
var response = await client.QueryObservables.ExecuteAsync(ContentFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryObservables;
```

### RejectContent

```csharp
var response = await client.RejectContent.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.RejectContent;
```

### ResearchContents

Research contents via web research based on provided filter criteria.

```csharp
var response = await client.ResearchContents.ExecuteAsync(
    ContentPublishingConnectorInput connector,
    ContentFilter? filter,
    string? name,
    EntityReferenceInput? summarySpecification,
    EntityReferenceInput? publishSpecification,
    EntityReferenceInput? workflow,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.ResearchContents;
```

### RestartContent

Restarts workflow on content.

```csharp
var response = await client.RestartContent.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.RestartContent;
```

### ScreenshotPage

Screenshot web page by URI.

```csharp
var response = await client.ScreenshotPage.ExecuteAsync(
    Uri uri,
    int? maximumHeight,
    bool? isSynchronous,
    EntityReferenceInput? workflow,
    IReadOnlyList<EntityReferenceInput>? collections,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.ScreenshotPage;
```

### SummarizeContents

Summarizes contents based on the provided filter criteria.

```csharp
var response = await client.SummarizeContents.ExecuteAsync(
    IReadOnlyList<SummarizationStrategyInput> summarizations,
    ContentFilter? filter,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.SummarizeContents;
```

### SummarizeText

Summarizes text.

```csharp
var response = await client.SummarizeText.ExecuteAsync(
    SummarizationStrategyInput summarization,
    string text,
    TextTypes? textType,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.SummarizeText;
```

### UpdateContent

Updates existing content.

```csharp
var response = await client.UpdateContent.ExecuteAsync(ContentUpdateInput content);
response.EnsureNoErrors();
var result = response.Data?.UpdateContent;
```

### AskGraphlit

Ask questions about the Graphlit API or SDKs. Can create code samples for any API call.

```csharp
var response = await client.AskGraphlit.ExecuteAsync(
    string prompt,
    SdkTypes? type,
    string? id,
    EntityReferenceInput? specification,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.AskGraphlit;
```

### BranchConversation

Branches an existing conversation.

```csharp
var response = await client.BranchConversation.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.BranchConversation;
```

### ClearConversation

Clears an existing conversation.

```csharp
var response = await client.ClearConversation.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.ClearConversation;
```

### CloseConversation

Closes an existing conversation.

```csharp
var response = await client.CloseConversation.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.CloseConversation;
```

### CompleteConversation

Complete a conversation with LLM assistant message.

```csharp
var response = await client.CompleteConversation.ExecuteAsync(
    string completion,
    string id,
    TimeSpan? completionTime,
    TimeSpan? ttft,
    double? throughput,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.CompleteConversation;
```

### ContinueConversation

Provide responses to called tools which continues prompted conversation.

```csharp
var response = await client.ContinueConversation.ExecuteAsync(
    string id,
    IReadOnlyList<ConversationToolResponseInput> responses,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.ContinueConversation;
```

### CountConversations

Counts conversations based on the provided filter criteria.

```csharp
var response = await client.CountConversations.ExecuteAsync(ConversationFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountConversations;
```

### CreateConversation

Creates a new conversation.

```csharp
var response = await client.CreateConversation.ExecuteAsync(ConversationInput conversation, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CreateConversation;
```

### DeleteAllConversations

Bulk deletes conversations based on the provided filter criteria.

```csharp
var response = await client.DeleteAllConversations.ExecuteAsync(
    ConversationFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllConversations;
```

### DeleteConversation

Deletes a conversation.

```csharp
var response = await client.DeleteConversation.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteConversation;
```

### DeleteConversations

Bulk deletes conversations.

```csharp
var response = await client.DeleteConversations.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteConversations;
```

### FormatConversation

Format a conversation LLM user prompt.

```csharp
var response = await client.FormatConversation.ExecuteAsync(
    string prompt,
    string? id,
    EntityReferenceInput? specification,
    IReadOnlyList<ToolDefinitionInput>? tools,
    string? systemPrompt,
    bool? includeDetails,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.FormatConversation;
```

### GetConversation

```csharp
var response = await client.GetConversation.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetConversation;
```

### Prompt

The LLM prompt, for custom summarization.

```csharp
var response = await client.Prompt.ExecuteAsync(
    string? prompt,
    string? mimeType,
    string? data,
    EntityReferenceInput? specification,
    IReadOnlyList<ConversationMessageInput>? messages,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.Prompt;
```

### PromptConversation

Prompts a conversation.

```csharp
var response = await client.PromptConversation.ExecuteAsync(
    string prompt,
    string? mimeType,
    string? data,
    string? id,
    EntityReferenceInput? specification,
    string? systemPrompt,
    IReadOnlyList<ToolDefinitionInput>? tools,
    bool? requireTool,
    bool? includeDetails,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.PromptConversation;
```

### PublishConversation

Publish conversation.

```csharp
var response = await client.PublishConversation.ExecuteAsync(
    string id,
    ContentPublishingConnectorInput connector,
    string? name,
    bool? isSynchronous,
    EntityReferenceInput? workflow,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.PublishConversation;
```

### QueryConversations

```csharp
var response = await client.QueryConversations.ExecuteAsync(ConversationFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryConversations;
```

### QueryConversationsClusters

```csharp
var response = await client.QueryConversationsClusters.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryConversationsClusters;
```

### QueryConversationsGraph

```csharp
var response = await client.QueryConversationsGraph.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryConversationsGraph;
```

### RetrieveEntities

```csharp
var response = await client.RetrieveEntities.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.RetrieveEntities;
```

### RetrieveFacts

```csharp
var response = await client.RetrieveFacts.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.RetrieveFacts;
```

### RetrieveSources

Retrieve content sources.

```csharp
var response = await client.RetrieveSources.ExecuteAsync(
    string prompt,
    ContentFilter? filter,
    ContentFilter? augmentedFilter,
    RetrievalStrategyInput? retrievalStrategy,
    RerankingStrategyInput? rerankingStrategy,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.RetrieveSources;
```

### RetrieveView

Retrieve content sources using a saved view.

```csharp
var response = await client.RetrieveView.ExecuteAsync(
    string prompt,
    string id,
    RetrievalStrategyInput? retrievalStrategy,
    RerankingStrategyInput? rerankingStrategy,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.RetrieveView;
```

### ReviseContent

Revise content via prompted conversation.

```csharp
var response = await client.ReviseContent.ExecuteAsync(
    string prompt,
    EntityReferenceInput content,
    string? id,
    EntityReferenceInput? specification,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.ReviseContent;
```

### ReviseEncodedImage

Revise encoded image via prompted conversation.

```csharp
var response = await client.ReviseEncodedImage.ExecuteAsync(
    string prompt,
    string mimeType,
    string data,
    string? id,
    EntityReferenceInput? specification,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.ReviseEncodedImage;
```

### ReviseImage

Revise image via prompted conversation.

```csharp
var response = await client.ReviseImage.ExecuteAsync(
    string prompt,
    Uri uri,
    string? id,
    EntityReferenceInput? specification,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.ReviseImage;
```

### ReviseText

Revise text via prompted conversation.

```csharp
var response = await client.ReviseText.ExecuteAsync(
    string prompt,
    string text,
    string? id,
    EntityReferenceInput? specification,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.ReviseText;
```

### SuggestConversation

Suggest prompts for a conversation.

```csharp
var response = await client.SuggestConversation.ExecuteAsync(
    string id,
    int? count,
    string? prompt,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.SuggestConversation;
```

### UpdateConversation

Updates an existing conversation.

```csharp
var response = await client.UpdateConversation.ExecuteAsync(ConversationUpdateInput conversation);
response.EnsureNoErrors();
var result = response.Data?.UpdateConversation;
```

### CountEmotions

```csharp
var response = await client.CountEmotions.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.CountEmotions;
```

### CreateEmotion

```csharp
var response = await client.CreateEmotion.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.CreateEmotion;
```

### DeleteAllEmotions

```csharp
var response = await client.DeleteAllEmotions.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllEmotions;
```

### DeleteEmotion

```csharp
var response = await client.DeleteEmotion.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.DeleteEmotion;
```

### DeleteEmotions

```csharp
var response = await client.DeleteEmotions.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.DeleteEmotions;
```

### GetEmotion

```csharp
var response = await client.GetEmotion.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.GetEmotion;
```

### QueryEmotions

```csharp
var response = await client.QueryEmotions.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryEmotions;
```

### UpdateEmotion

```csharp
var response = await client.UpdateEmotion.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.UpdateEmotion;
```

### CountEvents

Counts events based on the provided filter criteria.

```csharp
var response = await client.CountEvents.ExecuteAsync(EventFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountEvents;
```

### CreateEvent

Creates a new event.

```csharp
var response = await client.CreateEvent.ExecuteAsync(EventInput @event);
response.EnsureNoErrors();
var result = response.Data?.CreateEvent;
```

### DeleteAllEvents

Bulk deletes events based on the provided filter criteria.

```csharp
var response = await client.DeleteAllEvents.ExecuteAsync(
    EventFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllEvents;
```

### DeleteEvent

Deletes an event.

```csharp
var response = await client.DeleteEvent.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteEvent;
```

### DeleteEvents

Bulk deletes events.

```csharp
var response = await client.DeleteEvents.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteEvents;
```

### GetEvent

```csharp
var response = await client.GetEvent.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetEvent;
```

### QueryEvents

```csharp
var response = await client.QueryEvents.ExecuteAsync(EventFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryEvents;
```

### QueryEventsClusters

```csharp
var response = await client.QueryEventsClusters.ExecuteAsync(
    EventFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryEventsClusters;
```

### UpdateEvent

Updates an event.

```csharp
var response = await client.UpdateEvent.ExecuteAsync(EventUpdateInput @event);
response.EnsureNoErrors();
var result = response.Data?.UpdateEvent;
```

### CountFacts

```csharp
var response = await client.CountFacts.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.CountFacts;
```

### CreateFact

```csharp
var response = await client.CreateFact.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.CreateFact;
```

### DeleteAllFacts

```csharp
var response = await client.DeleteAllFacts.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllFacts;
```

### DeleteFact

```csharp
var response = await client.DeleteFact.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.DeleteFact;
```

### DeleteFacts

```csharp
var response = await client.DeleteFacts.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.DeleteFacts;
```

### GetFact

```csharp
var response = await client.GetFact.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.GetFact;
```

### QueryFacts

```csharp
var response = await client.QueryFacts.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryFacts;
```

### QueryFactsClusters

```csharp
var response = await client.QueryFactsClusters.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryFactsClusters;
```

### QueryFactsGraph

```csharp
var response = await client.QueryFactsGraph.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryFactsGraph;
```

### UpdateFact

```csharp
var response = await client.UpdateFact.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.UpdateFact;
```

### CountFeeds

Counts feeds based on the provided filter criteria.

```csharp
var response = await client.CountFeeds.ExecuteAsync(FeedFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountFeeds;
```

### CreateFeed

Creates a new feed.

```csharp
var response = await client.CreateFeed.ExecuteAsync(FeedInput feed, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CreateFeed;
```

### DeleteAllFeeds

Bulk deletes feeds based on the provided filter criteria.

```csharp
var response = await client.DeleteAllFeeds.ExecuteAsync(FeedFilter? filter, bool? isSynchronous, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllFeeds;
```

### DeleteFeed

Deletes a feed.

```csharp
var response = await client.DeleteFeed.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteFeed;
```

### DeleteFeeds

Bulk deletes feeds.

```csharp
var response = await client.DeleteFeeds.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteFeeds;
```

### DisableFeed

Disables a feed.

```csharp
var response = await client.DisableFeed.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DisableFeed;
```

### EnableFeed

Enables a feed.

```csharp
var response = await client.EnableFeed.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.EnableFeed;
```

### FeedExists

Returns whether any feed exists based on the provided filter criteria.

```csharp
var response = await client.FeedExists.ExecuteAsync(FeedFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.FeedExists;
```

### GetFeed

```csharp
var response = await client.GetFeed.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetFeed;
```

### GetSharePointConsentUri

```csharp
var response = await client.GetSharePointConsentUri.ExecuteAsync(string tenantId);
response.EnsureNoErrors();
var result = response.Data?.GetSharePointConsentUri;
```

### IsFeedDone

Returns if all the contents ingested from a feed have finished (or errored).

```csharp
var response = await client.IsFeedDone.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.IsFeedDone;
```

### QueryAsanaProjects

```csharp
var response = await client.QueryAsanaProjects.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryAsanaProjects;
```

### QueryAsanaWorkspaces

```csharp
var response = await client.QueryAsanaWorkspaces.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryAsanaWorkspaces;
```

### QueryAtlassianSites

```csharp
var response = await client.QueryAtlassianSites.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryAtlassianSites;
```

### QueryBambooHRDepartments

```csharp
var response = await client.QueryBambooHRDepartments.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryBambooHRDepartments;
```

### QueryBambooHRDivisions

```csharp
var response = await client.QueryBambooHRDivisions.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryBambooHRDivisions;
```

### QueryBambooHREmploymentStatuses

```csharp
var response = await client.QueryBambooHREmploymentStatuses.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryBambooHREmploymentStatuses;
```

### QueryBambooHRLocations

```csharp
var response = await client.QueryBambooHRLocations.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryBambooHRLocations;
```

### QueryBoxFolders

```csharp
var response = await client.QueryBoxFolders.ExecuteAsync(BoxFoldersInput properties, string? folderId);
response.EnsureNoErrors();
var result = response.Data?.QueryBoxFolders;
```

### QueryConfluenceSpaces

```csharp
var response = await client.QueryConfluenceSpaces.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryConfluenceSpaces;
```

### QueryDiscordChannels

```csharp
var response = await client.QueryDiscordChannels.ExecuteAsync(DiscordChannelsInput properties);
response.EnsureNoErrors();
var result = response.Data?.QueryDiscordChannels;
```

### QueryDiscordGuilds

```csharp
var response = await client.QueryDiscordGuilds.ExecuteAsync(DiscordGuildsInput properties);
response.EnsureNoErrors();
var result = response.Data?.QueryDiscordGuilds;
```

### QueryDropboxFolders

```csharp
var response = await client.QueryDropboxFolders.ExecuteAsync(DropboxFoldersInput properties, string? folderPath);
response.EnsureNoErrors();
var result = response.Data?.QueryDropboxFolders;
```

### QueryFeeds

```csharp
var response = await client.QueryFeeds.ExecuteAsync(FeedFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryFeeds;
```

### QueryGitHubRepositories

```csharp
var response = await client.QueryGitHubRepositories.ExecuteAsync(
    GitHubRepositoriesInput properties,
    GitHubRepositorySortTypes? sortBy
);
response.EnsureNoErrors();
var result = response.Data?.QueryGitHubRepositories;
```

### QueryGoogleCalendars

```csharp
var response = await client.QueryGoogleCalendars.ExecuteAsync(GoogleCalendarsInput properties);
response.EnsureNoErrors();
var result = response.Data?.QueryGoogleCalendars;
```

### QueryGoogleDriveFolders

```csharp
var response = await client.QueryGoogleDriveFolders.ExecuteAsync(GoogleDriveFoldersInput properties, string? folderId);
response.EnsureNoErrors();
var result = response.Data?.QueryGoogleDriveFolders;
```

### QueryGustoCompanies

```csharp
var response = await client.QueryGustoCompanies.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryGustoCompanies;
```

### QueryGustoDepartments

```csharp
var response = await client.QueryGustoDepartments.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryGustoDepartments;
```

### QueryGustoLocations

```csharp
var response = await client.QueryGustoLocations.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryGustoLocations;
```

### QueryJiraProjects

```csharp
var response = await client.QueryJiraProjects.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryJiraProjects;
```

### QueryLinearProjects

```csharp
var response = await client.QueryLinearProjects.ExecuteAsync(LinearProjectsInput properties);
response.EnsureNoErrors();
var result = response.Data?.QueryLinearProjects;
```

### QueryMicrosoftCalendars

```csharp
var response = await client.QueryMicrosoftCalendars.ExecuteAsync(MicrosoftCalendarsInput properties);
response.EnsureNoErrors();
var result = response.Data?.QueryMicrosoftCalendars;
```

### QueryMicrosoftTeamsChannels

```csharp
var response = await client.QueryMicrosoftTeamsChannels.ExecuteAsync(
    MicrosoftTeamsChannelsInput properties,
    string teamId
);
response.EnsureNoErrors();
var result = response.Data?.QueryMicrosoftTeamsChannels;
```

### QueryMicrosoftTeamsTeams

```csharp
var response = await client.QueryMicrosoftTeamsTeams.ExecuteAsync(MicrosoftTeamsTeamsInput properties);
response.EnsureNoErrors();
var result = response.Data?.QueryMicrosoftTeamsTeams;
```

### QueryMondayBoards

```csharp
var response = await client.QueryMondayBoards.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryMondayBoards;
```

### QueryNotionDatabases

```csharp
var response = await client.QueryNotionDatabases.ExecuteAsync(NotionDatabasesInput properties);
response.EnsureNoErrors();
var result = response.Data?.QueryNotionDatabases;
```

### QueryNotionPages

```csharp
var response = await client.QueryNotionPages.ExecuteAsync(NotionPagesInput properties, string identifier);
response.EnsureNoErrors();
var result = response.Data?.QueryNotionPages;
```

### QueryOneDriveFolders

```csharp
var response = await client.QueryOneDriveFolders.ExecuteAsync(OneDriveFoldersInput properties, string? folderId);
response.EnsureNoErrors();
var result = response.Data?.QueryOneDriveFolders;
```

### QuerySharePointFolders

```csharp
var response = await client.QuerySharePointFolders.ExecuteAsync(
    SharePointFoldersInput properties,
    string libraryId,
    string? folderId
);
response.EnsureNoErrors();
var result = response.Data?.QuerySharePointFolders;
```

### QuerySharePointLibraries

```csharp
var response = await client.QuerySharePointLibraries.ExecuteAsync(SharePointLibrariesInput properties);
response.EnsureNoErrors();
var result = response.Data?.QuerySharePointLibraries;
```

### QuerySlackChannels

```csharp
var response = await client.QuerySlackChannels.ExecuteAsync(SlackChannelsInput properties);
response.EnsureNoErrors();
var result = response.Data?.QuerySlackChannels;
```

### TriggerFeed

Triggers immediate processing of a recurring feed.

```csharp
var response = await client.TriggerFeed.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.TriggerFeed;
```

### UpdateFeed

Updates an existing feed.

```csharp
var response = await client.UpdateFeed.ExecuteAsync(FeedUpdateInput feed);
response.EnsureNoErrors();
var result = response.Data?.UpdateFeed;
```

### CountInvestments

Counts investments based on the provided filter criteria.

```csharp
var response = await client.CountInvestments.ExecuteAsync(InvestmentFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountInvestments;
```

### CreateInvestment

Creates a new investment.

```csharp
var response = await client.CreateInvestment.ExecuteAsync(InvestmentInput investment);
response.EnsureNoErrors();
var result = response.Data?.CreateInvestment;
```

### DeleteAllInvestments

Bulk deletes investments based on the provided filter criteria.

```csharp
var response = await client.DeleteAllInvestments.ExecuteAsync(
    InvestmentFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllInvestments;
```

### DeleteInvestment

Deletes a investment.

```csharp
var response = await client.DeleteInvestment.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteInvestment;
```

### DeleteInvestments

Bulk deletes investments.

```csharp
var response = await client.DeleteInvestments.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteInvestments;
```

### GetInvestment

```csharp
var response = await client.GetInvestment.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetInvestment;
```

### QueryInvestments

```csharp
var response = await client.QueryInvestments.ExecuteAsync(InvestmentFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryInvestments;
```

### QueryInvestmentsClusters

```csharp
var response = await client.QueryInvestmentsClusters.ExecuteAsync(
    InvestmentFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryInvestmentsClusters;
```

### QueryInvestmentsExpanded

```csharp
var response = await client.QueryInvestmentsExpanded.ExecuteAsync(InvestmentFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryInvestmentsExpanded;
```

### UpdateInvestment

Updates a investment.

```csharp
var response = await client.UpdateInvestment.ExecuteAsync(InvestmentUpdateInput investment);
response.EnsureNoErrors();
var result = response.Data?.UpdateInvestment;
```

### CountInvestmentFunds

Counts investment funds based on the provided filter criteria.

```csharp
var response = await client.CountInvestmentFunds.ExecuteAsync(InvestmentFundFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountInvestmentFunds;
```

### CreateInvestmentFund

Creates a new investment fund.

```csharp
var response = await client.CreateInvestmentFund.ExecuteAsync(InvestmentFundInput investmentFund);
response.EnsureNoErrors();
var result = response.Data?.CreateInvestmentFund;
```

### DeleteAllInvestmentFunds

Bulk deletes investment funds based on the provided filter criteria.

```csharp
var response = await client.DeleteAllInvestmentFunds.ExecuteAsync(
    InvestmentFundFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllInvestmentFunds;
```

### DeleteInvestmentFund

Deletes a investment fund.

```csharp
var response = await client.DeleteInvestmentFund.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteInvestmentFund;
```

### DeleteInvestmentFunds

Bulk deletes investment funds.

```csharp
var response = await client.DeleteInvestmentFunds.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteInvestmentFunds;
```

### GetInvestmentFund

```csharp
var response = await client.GetInvestmentFund.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetInvestmentFund;
```

### QueryInvestmentFunds

```csharp
var response = await client.QueryInvestmentFunds.ExecuteAsync(InvestmentFundFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryInvestmentFunds;
```

### QueryInvestmentFundsClusters

```csharp
var response = await client.QueryInvestmentFundsClusters.ExecuteAsync(
    InvestmentFundFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryInvestmentFundsClusters;
```

### QueryInvestmentFundsExpanded

```csharp
var response = await client.QueryInvestmentFundsExpanded.ExecuteAsync(
    InvestmentFundFilter? filter,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryInvestmentFundsExpanded;
```

### UpdateInvestmentFund

Updates a investment fund.

```csharp
var response = await client.UpdateInvestmentFund.ExecuteAsync(InvestmentFundUpdateInput investmentFund);
response.EnsureNoErrors();
var result = response.Data?.UpdateInvestmentFund;
```

### CountLabels

Counts labels based on the provided filter criteria.

```csharp
var response = await client.CountLabels.ExecuteAsync(LabelFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountLabels;
```

### CreateLabel

Creates a new label.

```csharp
var response = await client.CreateLabel.ExecuteAsync(LabelInput label);
response.EnsureNoErrors();
var result = response.Data?.CreateLabel;
```

### DeleteAllLabels

Bulk deletes labels based on the provided filter criteria.

```csharp
var response = await client.DeleteAllLabels.ExecuteAsync(
    LabelFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllLabels;
```

### DeleteLabel

Deletes a label.

```csharp
var response = await client.DeleteLabel.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteLabel;
```

### DeleteLabels

Bulk deletes labels.

```csharp
var response = await client.DeleteLabels.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteLabels;
```

### GetLabel

```csharp
var response = await client.GetLabel.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetLabel;
```

### QueryLabels

```csharp
var response = await client.QueryLabels.ExecuteAsync(LabelFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryLabels;
```

### UpdateLabel

Updates a label.

```csharp
var response = await client.UpdateLabel.ExecuteAsync(LabelUpdateInput label);
response.EnsureNoErrors();
var result = response.Data?.UpdateLabel;
```

### UpsertLabel

Upserts a label.

```csharp
var response = await client.UpsertLabel.ExecuteAsync(LabelInput label);
response.EnsureNoErrors();
var result = response.Data?.UpsertLabel;
```

### CountMedicalConditions

Counts medical conditions based on the provided filter criteria.

```csharp
var response = await client.CountMedicalConditions.ExecuteAsync(MedicalConditionFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountMedicalConditions;
```

### CreateMedicalCondition

Creates a new medical condition.

```csharp
var response = await client.CreateMedicalCondition.ExecuteAsync(MedicalConditionInput medicalCondition);
response.EnsureNoErrors();
var result = response.Data?.CreateMedicalCondition;
```

### DeleteAllMedicalConditions

Bulk deletes medical conditions based on the provided filter criteria.

```csharp
var response = await client.DeleteAllMedicalConditions.ExecuteAsync(
    MedicalConditionFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllMedicalConditions;
```

### DeleteMedicalCondition

Deletes a medical condition.

```csharp
var response = await client.DeleteMedicalCondition.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalCondition;
```

### DeleteMedicalConditions

Bulk deletes medical conditions.

```csharp
var response = await client.DeleteMedicalConditions.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalConditions;
```

### GetMedicalCondition

```csharp
var response = await client.GetMedicalCondition.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetMedicalCondition;
```

### QueryMedicalConditions

```csharp
var response = await client.QueryMedicalConditions.ExecuteAsync(MedicalConditionFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalConditions;
```

### QueryMedicalConditionsClusters

```csharp
var response = await client.QueryMedicalConditionsClusters.ExecuteAsync(
    MedicalConditionFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalConditionsClusters;
```

### UpdateMedicalCondition

Updates a medical condition.

```csharp
var response = await client.UpdateMedicalCondition.ExecuteAsync(MedicalConditionUpdateInput medicalCondition);
response.EnsureNoErrors();
var result = response.Data?.UpdateMedicalCondition;
```

### CountMedicalContraindications

Counts medical contraindications based on the provided filter criteria.

```csharp
var response = await client.CountMedicalContraindications.ExecuteAsync(
    MedicalContraindicationFilter? filter,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.CountMedicalContraindications;
```

### CreateMedicalContraindication

Creates a new medical contraindication.

```csharp
var response = await client.CreateMedicalContraindication.ExecuteAsync(
    MedicalContraindicationInput medicalContraindication
);
response.EnsureNoErrors();
var result = response.Data?.CreateMedicalContraindication;
```

### DeleteAllMedicalContraindications

Bulk deletes medical contraindications based on the provided filter criteria.

```csharp
var response = await client.DeleteAllMedicalContraindications.ExecuteAsync(
    MedicalContraindicationFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllMedicalContraindications;
```

### DeleteMedicalContraindication

Deletes a medical contraindication.

```csharp
var response = await client.DeleteMedicalContraindication.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalContraindication;
```

### DeleteMedicalContraindications

Bulk deletes medical contraindications.

```csharp
var response = await client.DeleteMedicalContraindications.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalContraindications;
```

### GetMedicalContraindication

```csharp
var response = await client.GetMedicalContraindication.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetMedicalContraindication;
```

### QueryMedicalContraindications

```csharp
var response = await client.QueryMedicalContraindications.ExecuteAsync(
    MedicalContraindicationFilter? filter,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalContraindications;
```

### QueryMedicalContraindicationsClusters

```csharp
var response = await client.QueryMedicalContraindicationsClusters.ExecuteAsync(
    MedicalContraindicationFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalContraindicationsClusters;
```

### UpdateMedicalContraindication

Updates a medical contraindication.

```csharp
var response = await client.UpdateMedicalContraindication.ExecuteAsync(
    MedicalContraindicationUpdateInput medicalContraindication
);
response.EnsureNoErrors();
var result = response.Data?.UpdateMedicalContraindication;
```

### CountMedicalDevices

Counts medical devices based on the provided filter criteria.

```csharp
var response = await client.CountMedicalDevices.ExecuteAsync(MedicalDeviceFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountMedicalDevices;
```

### CreateMedicalDevice

Creates a new medical device.

```csharp
var response = await client.CreateMedicalDevice.ExecuteAsync(MedicalDeviceInput medicalDevice);
response.EnsureNoErrors();
var result = response.Data?.CreateMedicalDevice;
```

### DeleteAllMedicalDevices

Bulk deletes medical devices based on the provided filter criteria.

```csharp
var response = await client.DeleteAllMedicalDevices.ExecuteAsync(
    MedicalDeviceFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllMedicalDevices;
```

### DeleteMedicalDevice

Deletes a medical device.

```csharp
var response = await client.DeleteMedicalDevice.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalDevice;
```

### DeleteMedicalDevices

Bulk deletes medical devices.

```csharp
var response = await client.DeleteMedicalDevices.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalDevices;
```

### GetMedicalDevice

```csharp
var response = await client.GetMedicalDevice.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetMedicalDevice;
```

### QueryMedicalDevices

```csharp
var response = await client.QueryMedicalDevices.ExecuteAsync(MedicalDeviceFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalDevices;
```

### QueryMedicalDevicesClusters

```csharp
var response = await client.QueryMedicalDevicesClusters.ExecuteAsync(
    MedicalDeviceFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalDevicesClusters;
```

### UpdateMedicalDevice

Updates a medical device.

```csharp
var response = await client.UpdateMedicalDevice.ExecuteAsync(MedicalDeviceUpdateInput medicalDevice);
response.EnsureNoErrors();
var result = response.Data?.UpdateMedicalDevice;
```

### CountMedicalDrugs

Counts medical drugs based on the provided filter criteria.

```csharp
var response = await client.CountMedicalDrugs.ExecuteAsync(MedicalDrugFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountMedicalDrugs;
```

### CreateMedicalDrug

Creates a new medical drug.

```csharp
var response = await client.CreateMedicalDrug.ExecuteAsync(MedicalDrugInput medicalDrug);
response.EnsureNoErrors();
var result = response.Data?.CreateMedicalDrug;
```

### DeleteAllMedicalDrugs

Bulk deletes medical drugs based on the provided filter criteria.

```csharp
var response = await client.DeleteAllMedicalDrugs.ExecuteAsync(
    MedicalDrugFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllMedicalDrugs;
```

### DeleteMedicalDrug

Deletes a medical drug.

```csharp
var response = await client.DeleteMedicalDrug.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalDrug;
```

### DeleteMedicalDrugs

Bulk deletes medical drugs.

```csharp
var response = await client.DeleteMedicalDrugs.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalDrugs;
```

### GetMedicalDrug

```csharp
var response = await client.GetMedicalDrug.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetMedicalDrug;
```

### QueryMedicalDrugs

```csharp
var response = await client.QueryMedicalDrugs.ExecuteAsync(MedicalDrugFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalDrugs;
```

### QueryMedicalDrugsClusters

```csharp
var response = await client.QueryMedicalDrugsClusters.ExecuteAsync(
    MedicalDrugFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalDrugsClusters;
```

### UpdateMedicalDrug

Updates a medical drug.

```csharp
var response = await client.UpdateMedicalDrug.ExecuteAsync(MedicalDrugUpdateInput medicalDrug);
response.EnsureNoErrors();
var result = response.Data?.UpdateMedicalDrug;
```

### CountMedicalDrugClasses

Counts medical drug classes based on the provided filter criteria.

```csharp
var response = await client.CountMedicalDrugClasses.ExecuteAsync(MedicalDrugClassFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountMedicalDrugClasses;
```

### CreateMedicalDrugClass

Creates a new medical drug class.

```csharp
var response = await client.CreateMedicalDrugClass.ExecuteAsync(MedicalDrugClassInput medicalDrugClass);
response.EnsureNoErrors();
var result = response.Data?.CreateMedicalDrugClass;
```

### DeleteAllMedicalDrugClasses

Bulk deletes medical drug classes based on the provided filter criteria.

```csharp
var response = await client.DeleteAllMedicalDrugClasses.ExecuteAsync(
    MedicalDrugClassFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllMedicalDrugClasses;
```

### DeleteMedicalDrugClass

Deletes a medical drug class.

```csharp
var response = await client.DeleteMedicalDrugClass.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalDrugClass;
```

### DeleteMedicalDrugClasses

Bulk deletes medical drug classes.

```csharp
var response = await client.DeleteMedicalDrugClasses.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalDrugClasses;
```

### GetMedicalDrugClass

```csharp
var response = await client.GetMedicalDrugClass.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetMedicalDrugClass;
```

### QueryMedicalDrugClasses

```csharp
var response = await client.QueryMedicalDrugClasses.ExecuteAsync(MedicalDrugClassFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalDrugClasses;
```

### QueryMedicalDrugClassesClusters

```csharp
var response = await client.QueryMedicalDrugClassesClusters.ExecuteAsync(
    MedicalDrugClassFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalDrugClassesClusters;
```

### UpdateMedicalDrugClass

Updates a medical drug class.

```csharp
var response = await client.UpdateMedicalDrugClass.ExecuteAsync(MedicalDrugClassUpdateInput medicalDrugClass);
response.EnsureNoErrors();
var result = response.Data?.UpdateMedicalDrugClass;
```

### CountMedicalGuidelines

Counts medical guidelines based on the provided filter criteria.

```csharp
var response = await client.CountMedicalGuidelines.ExecuteAsync(MedicalGuidelineFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountMedicalGuidelines;
```

### CreateMedicalGuideline

Creates a new medical guideline.

```csharp
var response = await client.CreateMedicalGuideline.ExecuteAsync(MedicalGuidelineInput medicalGuideline);
response.EnsureNoErrors();
var result = response.Data?.CreateMedicalGuideline;
```

### DeleteAllMedicalGuidelines

Bulk deletes medical guidelines based on the provided filter criteria.

```csharp
var response = await client.DeleteAllMedicalGuidelines.ExecuteAsync(
    MedicalGuidelineFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllMedicalGuidelines;
```

### DeleteMedicalGuideline

Deletes a medical guideline.

```csharp
var response = await client.DeleteMedicalGuideline.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalGuideline;
```

### DeleteMedicalGuidelines

Bulk deletes medical guidelines.

```csharp
var response = await client.DeleteMedicalGuidelines.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalGuidelines;
```

### GetMedicalGuideline

```csharp
var response = await client.GetMedicalGuideline.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetMedicalGuideline;
```

### QueryMedicalGuidelines

```csharp
var response = await client.QueryMedicalGuidelines.ExecuteAsync(MedicalGuidelineFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalGuidelines;
```

### QueryMedicalGuidelinesClusters

```csharp
var response = await client.QueryMedicalGuidelinesClusters.ExecuteAsync(
    MedicalGuidelineFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalGuidelinesClusters;
```

### UpdateMedicalGuideline

Updates a medical guideline.

```csharp
var response = await client.UpdateMedicalGuideline.ExecuteAsync(MedicalGuidelineUpdateInput medicalGuideline);
response.EnsureNoErrors();
var result = response.Data?.UpdateMedicalGuideline;
```

### CountMedicalIndications

Counts medical Indications based on the provided filter criteria.

```csharp
var response = await client.CountMedicalIndications.ExecuteAsync(
    MedicalIndicationFilter? filter,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.CountMedicalIndications;
```

### CreateMedicalIndication

Creates a new medical indication.

```csharp
var response = await client.CreateMedicalIndication.ExecuteAsync(MedicalIndicationInput medicalIndication);
response.EnsureNoErrors();
var result = response.Data?.CreateMedicalIndication;
```

### DeleteAllMedicalIndications

Bulk deletes medical indications based on the provided filter criteria.

```csharp
var response = await client.DeleteAllMedicalIndications.ExecuteAsync(
    MedicalIndicationFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllMedicalIndications;
```

### DeleteMedicalIndication

Deletes a medical indication.

```csharp
var response = await client.DeleteMedicalIndication.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalIndication;
```

### DeleteMedicalIndications

Bulk deletes medical indications.

```csharp
var response = await client.DeleteMedicalIndications.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalIndications;
```

### GetMedicalIndication

```csharp
var response = await client.GetMedicalIndication.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetMedicalIndication;
```

### QueryMedicalIndications

```csharp
var response = await client.QueryMedicalIndications.ExecuteAsync(
    MedicalIndicationFilter? filter,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalIndications;
```

### QueryMedicalIndicationsClusters

```csharp
var response = await client.QueryMedicalIndicationsClusters.ExecuteAsync(
    MedicalIndicationFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalIndicationsClusters;
```

### UpdateMedicalIndication

Updates a medical indication.

```csharp
var response = await client.UpdateMedicalIndication.ExecuteAsync(MedicalIndicationUpdateInput medicalIndication);
response.EnsureNoErrors();
var result = response.Data?.UpdateMedicalIndication;
```

### CountMedicalProcedures

Counts medical procedures based on the provided filter criteria.

```csharp
var response = await client.CountMedicalProcedures.ExecuteAsync(MedicalProcedureFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountMedicalProcedures;
```

### CreateMedicalProcedure

Creates a new medical procedure.

```csharp
var response = await client.CreateMedicalProcedure.ExecuteAsync(MedicalProcedureInput medicalProcedure);
response.EnsureNoErrors();
var result = response.Data?.CreateMedicalProcedure;
```

### DeleteAllMedicalProcedures

Bulk deletes medical procedures based on the provided filter criteria.

```csharp
var response = await client.DeleteAllMedicalProcedures.ExecuteAsync(
    MedicalProcedureFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllMedicalProcedures;
```

### DeleteMedicalProcedure

Deletes a medical procedure.

```csharp
var response = await client.DeleteMedicalProcedure.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalProcedure;
```

### DeleteMedicalProcedures

Bulk deletes medical procedures.

```csharp
var response = await client.DeleteMedicalProcedures.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalProcedures;
```

### GetMedicalProcedure

```csharp
var response = await client.GetMedicalProcedure.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetMedicalProcedure;
```

### QueryMedicalProcedures

```csharp
var response = await client.QueryMedicalProcedures.ExecuteAsync(MedicalProcedureFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalProcedures;
```

### QueryMedicalProceduresClusters

```csharp
var response = await client.QueryMedicalProceduresClusters.ExecuteAsync(
    MedicalProcedureFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalProceduresClusters;
```

### UpdateMedicalProcedure

Updates a medical procedure.

```csharp
var response = await client.UpdateMedicalProcedure.ExecuteAsync(MedicalProcedureUpdateInput medicalProcedure);
response.EnsureNoErrors();
var result = response.Data?.UpdateMedicalProcedure;
```

### CountMedicalStudies

Counts medical studies based on the provided filter criteria.

```csharp
var response = await client.CountMedicalStudies.ExecuteAsync(MedicalStudyFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountMedicalStudies;
```

### CreateMedicalStudy

Creates a new medical study.

```csharp
var response = await client.CreateMedicalStudy.ExecuteAsync(MedicalStudyInput medicalStudy);
response.EnsureNoErrors();
var result = response.Data?.CreateMedicalStudy;
```

### DeleteAllMedicalStudies

Bulk deletes medical studies based on the provided filter criteria.

```csharp
var response = await client.DeleteAllMedicalStudies.ExecuteAsync(
    MedicalStudyFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllMedicalStudies;
```

### DeleteMedicalStudies

Bulk deletes medical studies.

```csharp
var response = await client.DeleteMedicalStudies.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalStudies;
```

### DeleteMedicalStudy

Deletes a medical study.

```csharp
var response = await client.DeleteMedicalStudy.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalStudy;
```

### GetMedicalStudy

```csharp
var response = await client.GetMedicalStudy.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetMedicalStudy;
```

### QueryMedicalStudies

```csharp
var response = await client.QueryMedicalStudies.ExecuteAsync(MedicalStudyFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalStudies;
```

### QueryMedicalStudiesClusters

```csharp
var response = await client.QueryMedicalStudiesClusters.ExecuteAsync(
    MedicalStudyFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalStudiesClusters;
```

### UpdateMedicalStudy

Updates a medical study.

```csharp
var response = await client.UpdateMedicalStudy.ExecuteAsync(MedicalStudyUpdateInput medicalStudy);
response.EnsureNoErrors();
var result = response.Data?.UpdateMedicalStudy;
```

### CountMedicalTests

Counts medical tests based on the provided filter criteria.

```csharp
var response = await client.CountMedicalTests.ExecuteAsync(MedicalTestFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountMedicalTests;
```

### CreateMedicalTest

Creates a new medical test.

```csharp
var response = await client.CreateMedicalTest.ExecuteAsync(MedicalTestInput medicalTest);
response.EnsureNoErrors();
var result = response.Data?.CreateMedicalTest;
```

### DeleteAllMedicalTests

Bulk deletes medical tests based on the provided filter criteria.

```csharp
var response = await client.DeleteAllMedicalTests.ExecuteAsync(
    MedicalTestFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllMedicalTests;
```

### DeleteMedicalTest

Deletes a medical test.

```csharp
var response = await client.DeleteMedicalTest.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalTest;
```

### DeleteMedicalTests

Bulk deletes medical tests.

```csharp
var response = await client.DeleteMedicalTests.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalTests;
```

### GetMedicalTest

```csharp
var response = await client.GetMedicalTest.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetMedicalTest;
```

### QueryMedicalTests

```csharp
var response = await client.QueryMedicalTests.ExecuteAsync(MedicalTestFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalTests;
```

### QueryMedicalTestsClusters

```csharp
var response = await client.QueryMedicalTestsClusters.ExecuteAsync(
    MedicalTestFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalTestsClusters;
```

### UpdateMedicalTest

Updates a medical test.

```csharp
var response = await client.UpdateMedicalTest.ExecuteAsync(MedicalTestUpdateInput medicalTest);
response.EnsureNoErrors();
var result = response.Data?.UpdateMedicalTest;
```

### CountMedicalTherapies

Counts medical therapies based on the provided filter criteria.

```csharp
var response = await client.CountMedicalTherapies.ExecuteAsync(MedicalTherapyFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountMedicalTherapies;
```

### CreateMedicalTherapy

Creates a new medical therapy.

```csharp
var response = await client.CreateMedicalTherapy.ExecuteAsync(MedicalTherapyInput medicalTherapy);
response.EnsureNoErrors();
var result = response.Data?.CreateMedicalTherapy;
```

### DeleteAllMedicalTherapies

Bulk deletes medical therapies based on the provided filter criteria.

```csharp
var response = await client.DeleteAllMedicalTherapies.ExecuteAsync(
    MedicalTherapyFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllMedicalTherapies;
```

### DeleteMedicalTherapies

Bulk deletes medical therapies.

```csharp
var response = await client.DeleteMedicalTherapies.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalTherapies;
```

### DeleteMedicalTherapy

Deletes a medical therapy.

```csharp
var response = await client.DeleteMedicalTherapy.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteMedicalTherapy;
```

### GetMedicalTherapy

```csharp
var response = await client.GetMedicalTherapy.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetMedicalTherapy;
```

### QueryMedicalTherapies

```csharp
var response = await client.QueryMedicalTherapies.ExecuteAsync(MedicalTherapyFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalTherapies;
```

### QueryMedicalTherapiesClusters

```csharp
var response = await client.QueryMedicalTherapiesClusters.ExecuteAsync(
    MedicalTherapyFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryMedicalTherapiesClusters;
```

### UpdateMedicalTherapy

Updates a medical therapy.

```csharp
var response = await client.UpdateMedicalTherapy.ExecuteAsync(MedicalTherapyUpdateInput medicalTherapy);
response.EnsureNoErrors();
var result = response.Data?.UpdateMedicalTherapy;
```

### SendNotification

Sends a notification.

```csharp
var response = await client.SendNotification.ExecuteAsync(
    IntegrationConnectorInput connector,
    string text,
    TextTypes? textType
);
response.EnsureNoErrors();
var result = response.Data?.SendNotification;
```

### CreateObservation

Creates a new observation.

```csharp
var response = await client.CreateObservation.ExecuteAsync(ObservationInput observation);
response.EnsureNoErrors();
var result = response.Data?.CreateObservation;
```

### DeleteObservation

Deletes an observation.

```csharp
var response = await client.DeleteObservation.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteObservation;
```

### MatchEntity

Matches an extracted observable entity to a known entity from a list of candidates using LLM reasoning.

```csharp
var response = await client.MatchEntity.ExecuteAsync(
    ObservableInput observable,
    IReadOnlyList<EntityReferenceInput> candidates,
    EntityReferenceInput? specification,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.MatchEntity;
```

### ResolveEntities

Resolves duplicate entities into a single primary entity using LLM reasoning. Returns clusters of suggested groupings if resolution is not executed.

```csharp
var response = await client.ResolveEntities.ExecuteAsync(
    ObservableTypes type,
    IReadOnlyList<EntityReferenceInput> entities,
    double? threshold,
    EntityReferenceInput? specification,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.ResolveEntities;
```

### ResolveEntity

Resolves a source entity into a target entity using LLM-driven metadata merging. The target is always the primary\/canonical entity.

```csharp
var response = await client.ResolveEntity.ExecuteAsync(
    ObservableTypes type,
    EntityReferenceInput source,
    EntityReferenceInput target,
    EntityReferenceInput? specification,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.ResolveEntity;
```

### UpdateObservation

Updates an observation.

```csharp
var response = await client.UpdateObservation.ExecuteAsync(ObservationUpdateInput observation);
response.EnsureNoErrors();
var result = response.Data?.UpdateObservation;
```

### CountOrganizations

Counts organizations based on the provided filter criteria.

```csharp
var response = await client.CountOrganizations.ExecuteAsync(OrganizationFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountOrganizations;
```

### CreateOrganization

Creates a new organization.

```csharp
var response = await client.CreateOrganization.ExecuteAsync(OrganizationInput organization);
response.EnsureNoErrors();
var result = response.Data?.CreateOrganization;
```

### DeleteAllOrganizations

Bulk deletes organizations based on the provided filter criteria.

```csharp
var response = await client.DeleteAllOrganizations.ExecuteAsync(
    OrganizationFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllOrganizations;
```

### DeleteOrganization

Deletes an organization.

```csharp
var response = await client.DeleteOrganization.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteOrganization;
```

### DeleteOrganizations

Bulk deletes organizations.

```csharp
var response = await client.DeleteOrganizations.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteOrganizations;
```

### EnrichOrganizations

Enriches organizations matching the filter criteria using the specified enrichment connector.

```csharp
var response = await client.EnrichOrganizations.ExecuteAsync(
    OrganizationFilter? filter,
    EntityEnrichmentConnectorInput connector,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.EnrichOrganizations;
```

### GetOrganization

```csharp
var response = await client.GetOrganization.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetOrganization;
```

### QueryOrganizations

```csharp
var response = await client.QueryOrganizations.ExecuteAsync(OrganizationFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryOrganizations;
```

### QueryOrganizationsClusters

```csharp
var response = await client.QueryOrganizationsClusters.ExecuteAsync(
    OrganizationFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryOrganizationsClusters;
```

### QueryOrganizationsExpanded

```csharp
var response = await client.QueryOrganizationsExpanded.ExecuteAsync(OrganizationFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryOrganizationsExpanded;
```

### UpdateOrganization

Updates an organization.

```csharp
var response = await client.UpdateOrganization.ExecuteAsync(OrganizationUpdateInput organization);
response.EnsureNoErrors();
var result = response.Data?.UpdateOrganization;
```

### CountPersons

Counts persons based on the provided filter criteria.

```csharp
var response = await client.CountPersons.ExecuteAsync(PersonFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountPersons;
```

### CreatePerson

Creates a new person.

```csharp
var response = await client.CreatePerson.ExecuteAsync(PersonInput person);
response.EnsureNoErrors();
var result = response.Data?.CreatePerson;
```

### DeleteAllPersons

Bulk deletes persons based on the provided filter criteria.

```csharp
var response = await client.DeleteAllPersons.ExecuteAsync(
    PersonFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllPersons;
```

### DeletePerson

Deletes a person.

```csharp
var response = await client.DeletePerson.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeletePerson;
```

### DeletePersons

Bulk deletes persons.

```csharp
var response = await client.DeletePersons.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeletePersons;
```

### EnrichPersons

Enriches persons matching the filter criteria using the specified enrichment connector.

```csharp
var response = await client.EnrichPersons.ExecuteAsync(
    PersonFilter? filter,
    EntityEnrichmentConnectorInput connector,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.EnrichPersons;
```

### GetPerson

```csharp
var response = await client.GetPerson.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetPerson;
```

### QueryPersons

```csharp
var response = await client.QueryPersons.ExecuteAsync(PersonFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryPersons;
```

### QueryPersonsClusters

```csharp
var response = await client.QueryPersonsClusters.ExecuteAsync(
    PersonFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryPersonsClusters;
```

### QueryPersonsExpanded

```csharp
var response = await client.QueryPersonsExpanded.ExecuteAsync(PersonFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryPersonsExpanded;
```

### UpdatePerson

Updates a person.

```csharp
var response = await client.UpdatePerson.ExecuteAsync(PersonUpdateInput person);
response.EnsureNoErrors();
var result = response.Data?.UpdatePerson;
```

### CountPersonas

```csharp
var response = await client.CountPersonas.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.CountPersonas;
```

### CreatePersona

```csharp
var response = await client.CreatePersona.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.CreatePersona;
```

### DeleteAllPersonas

```csharp
var response = await client.DeleteAllPersonas.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllPersonas;
```

### DeletePersona

```csharp
var response = await client.DeletePersona.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.DeletePersona;
```

### DeletePersonas

```csharp
var response = await client.DeletePersonas.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.DeletePersonas;
```

### GetPersona

```csharp
var response = await client.GetPersona.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.GetPersona;
```

### QueryPersonas

```csharp
var response = await client.QueryPersonas.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.QueryPersonas;
```

### UpdatePersona

```csharp
var response = await client.UpdatePersona.ExecuteAsync(...);
response.EnsureNoErrors();
var result = response.Data?.UpdatePersona;
```

### CountPlaces

Counts places based on the provided filter criteria.

```csharp
var response = await client.CountPlaces.ExecuteAsync(PlaceFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountPlaces;
```

### CreatePlace

Creates a new place.

```csharp
var response = await client.CreatePlace.ExecuteAsync(PlaceInput place);
response.EnsureNoErrors();
var result = response.Data?.CreatePlace;
```

### DeleteAllPlaces

Bulk deletes places based on the provided filter criteria.

```csharp
var response = await client.DeleteAllPlaces.ExecuteAsync(
    PlaceFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllPlaces;
```

### DeletePlace

Deletes a place.

```csharp
var response = await client.DeletePlace.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeletePlace;
```

### DeletePlaces

Bulk deletes places.

```csharp
var response = await client.DeletePlaces.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeletePlaces;
```

### EnrichPlaces

Enriches places matching the filter criteria using the specified enrichment connector.

```csharp
var response = await client.EnrichPlaces.ExecuteAsync(
    PlaceFilter? filter,
    EntityEnrichmentConnectorInput connector,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.EnrichPlaces;
```

### GetPlace

```csharp
var response = await client.GetPlace.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetPlace;
```

### QueryPlaces

```csharp
var response = await client.QueryPlaces.ExecuteAsync(PlaceFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryPlaces;
```

### QueryPlacesClusters

```csharp
var response = await client.QueryPlacesClusters.ExecuteAsync(
    PlaceFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryPlacesClusters;
```

### UpdatePlace

Updates a place.

```csharp
var response = await client.UpdatePlace.ExecuteAsync(PlaceUpdateInput place);
response.EnsureNoErrors();
var result = response.Data?.UpdatePlace;
```

### CountProducts

Counts products based on the provided filter criteria.

```csharp
var response = await client.CountProducts.ExecuteAsync(ProductFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountProducts;
```

### CreateProduct

Creates a new product.

```csharp
var response = await client.CreateProduct.ExecuteAsync(ProductInput product);
response.EnsureNoErrors();
var result = response.Data?.CreateProduct;
```

### DeleteAllProducts

Bulk deletes products based on the provided filter criteria.

```csharp
var response = await client.DeleteAllProducts.ExecuteAsync(
    ProductFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllProducts;
```

### DeleteProduct

Deletes a product.

```csharp
var response = await client.DeleteProduct.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteProduct;
```

### DeleteProducts

Bulk deletes products.

```csharp
var response = await client.DeleteProducts.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteProducts;
```

### EnrichProducts

Enriches products matching the filter criteria using the specified enrichment connector.

```csharp
var response = await client.EnrichProducts.ExecuteAsync(
    ProductFilter? filter,
    EntityEnrichmentConnectorInput connector,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.EnrichProducts;
```

### GetProduct

```csharp
var response = await client.GetProduct.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetProduct;
```

### QueryProducts

```csharp
var response = await client.QueryProducts.ExecuteAsync(ProductFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryProducts;
```

### QueryProductsClusters

```csharp
var response = await client.QueryProductsClusters.ExecuteAsync(
    ProductFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryProductsClusters;
```

### UpdateProduct

Updates a product.

```csharp
var response = await client.UpdateProduct.ExecuteAsync(ProductUpdateInput product);
response.EnsureNoErrors();
var result = response.Data?.UpdateProduct;
```

### GetProject

```csharp
var response = await client.GetProject.ExecuteAsync();
response.EnsureNoErrors();
var result = response.Data?.GetProject;
```

### LookupCredits

Lookup credit usage given tenant correlation identifier.

```csharp
var response = await client.LookupCredits.ExecuteAsync(
    string correlationId,
    DateTimeOffset? startDate,
    TimeSpan? duration
);
response.EnsureNoErrors();
var result = response.Data?.LookupCredits;
```

### LookupUsage

Lookup usage records given tenant correlation identifier.

```csharp
var response = await client.LookupUsage.ExecuteAsync(
    string correlationId,
    DateTimeOffset? startDate,
    TimeSpan? duration
);
response.EnsureNoErrors();
var result = response.Data?.LookupUsage;
```

### QueryCredits

```csharp
var response = await client.QueryCredits.ExecuteAsync(DateTimeOffset startDate, TimeSpan duration);
response.EnsureNoErrors();
var result = response.Data?.QueryCredits;
```

### QueryTokens

```csharp
var response = await client.QueryTokens.ExecuteAsync(DateTimeOffset startDate, TimeSpan duration);
response.EnsureNoErrors();
var result = response.Data?.QueryTokens;
```

### QueryUsage

```csharp
var response = await client.QueryUsage.ExecuteAsync(
    DateTimeOffset startDate,
    TimeSpan duration,
    IReadOnlyList<string>? names,
    IReadOnlyList<string>? excludedNames,
    int? offset,
    int? limit
);
response.EnsureNoErrors();
var result = response.Data?.QueryUsage;
```

### UpdateProject

Updates project.

```csharp
var response = await client.UpdateProject.ExecuteAsync(ProjectUpdateInput project);
response.EnsureNoErrors();
var result = response.Data?.UpdateProject;
```

### CountRepos

Counts repos based on the provided filter criteria.

```csharp
var response = await client.CountRepos.ExecuteAsync(RepoFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountRepos;
```

### CreateRepo

Creates a new repo.

```csharp
var response = await client.CreateRepo.ExecuteAsync(RepoInput repo);
response.EnsureNoErrors();
var result = response.Data?.CreateRepo;
```

### DeleteAllRepos

Bulk deletes repos based on the provided filter criteria.

```csharp
var response = await client.DeleteAllRepos.ExecuteAsync(RepoFilter? filter, bool? isSynchronous, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllRepos;
```

### DeleteRepo

Deletes a repo.

```csharp
var response = await client.DeleteRepo.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteRepo;
```

### DeleteRepos

Bulk deletes repos.

```csharp
var response = await client.DeleteRepos.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteRepos;
```

### GetRepo

```csharp
var response = await client.GetRepo.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetRepo;
```

### QueryRepos

```csharp
var response = await client.QueryRepos.ExecuteAsync(RepoFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryRepos;
```

### QueryReposClusters

```csharp
var response = await client.QueryReposClusters.ExecuteAsync(
    RepoFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QueryReposClusters;
```

### UpdateRepo

Updates a repo.

```csharp
var response = await client.UpdateRepo.ExecuteAsync(RepoUpdateInput repo);
response.EnsureNoErrors();
var result = response.Data?.UpdateRepo;
```

### MapWeb

Enumerates the web pages at or beneath the provided URL using web sitemap.

```csharp
var response = await client.MapWeb.ExecuteAsync(
    Uri uri,
    IReadOnlyList<string>? allowedPaths,
    IReadOnlyList<string>? excludedPaths,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.MapWeb;
```

### SearchWeb

Searches the web based on the provided properties.

```csharp
var response = await client.SearchWeb.ExecuteAsync(
    string text,
    SearchServiceTypes? service,
    int? limit,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.SearchWeb;
```

### CountSoftwares

Counts software based on the provided filter criteria.

```csharp
var response = await client.CountSoftwares.ExecuteAsync(SoftwareFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountSoftwares;
```

### CreateSoftware

Creates a new software.

```csharp
var response = await client.CreateSoftware.ExecuteAsync(SoftwareInput software);
response.EnsureNoErrors();
var result = response.Data?.CreateSoftware;
```

### DeleteAllSoftwares

Bulk deletes software based on the provided filter criteria.

```csharp
var response = await client.DeleteAllSoftwares.ExecuteAsync(
    SoftwareFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllSoftwares;
```

### DeleteSoftware

Deletes a software.

```csharp
var response = await client.DeleteSoftware.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteSoftware;
```

### DeleteSoftwares

Bulk deletes software.

```csharp
var response = await client.DeleteSoftwares.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteSoftwares;
```

### GetSoftware

```csharp
var response = await client.GetSoftware.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetSoftware;
```

### QuerySoftwares

```csharp
var response = await client.QuerySoftwares.ExecuteAsync(SoftwareFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QuerySoftwares;
```

### QuerySoftwaresClusters

```csharp
var response = await client.QuerySoftwaresClusters.ExecuteAsync(
    SoftwareFilter? filter,
    EntityClustersInput? clusters,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.QuerySoftwaresClusters;
```

### UpdateSoftware

Updates a software.

```csharp
var response = await client.UpdateSoftware.ExecuteAsync(SoftwareUpdateInput software);
response.EnsureNoErrors();
var result = response.Data?.UpdateSoftware;
```

### CountSpecifications

Counts specifications based on the provided filter criteria.

```csharp
var response = await client.CountSpecifications.ExecuteAsync(SpecificationFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountSpecifications;
```

### CreateSpecification

Creates a new LLM specification.

```csharp
var response = await client.CreateSpecification.ExecuteAsync(SpecificationInput specification);
response.EnsureNoErrors();
var result = response.Data?.CreateSpecification;
```

### DeleteAllSpecifications

Bulk deletes specifications based on the provided filter criteria.

```csharp
var response = await client.DeleteAllSpecifications.ExecuteAsync(
    SpecificationFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllSpecifications;
```

### DeleteSpecification

Deletes a LLM specification.

```csharp
var response = await client.DeleteSpecification.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteSpecification;
```

### DeleteSpecifications

Deletes multiple specifications given their IDs.

```csharp
var response = await client.DeleteSpecifications.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteSpecifications;
```

### GetSpecification

```csharp
var response = await client.GetSpecification.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetSpecification;
```

### PromptSpecifications

Prompts one or more LLM specifications, 10 maximum.

```csharp
var response = await client.PromptSpecifications.ExecuteAsync(string prompt, IReadOnlyList<string> ids);
response.EnsureNoErrors();
var result = response.Data?.PromptSpecifications;
```

### QueryModels

```csharp
var response = await client.QueryModels.ExecuteAsync(ModelFilter? filter);
response.EnsureNoErrors();
var result = response.Data?.QueryModels;
```

### QuerySpecifications

```csharp
var response = await client.QuerySpecifications.ExecuteAsync(SpecificationFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QuerySpecifications;
```

### SpecificationExists

Returns whether any specification exists based on the provided filter criteria.

```csharp
var response = await client.SpecificationExists.ExecuteAsync(SpecificationFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.SpecificationExists;
```

### UpdateSpecification

Updates an existing LLM specification.

```csharp
var response = await client.UpdateSpecification.ExecuteAsync(SpecificationUpdateInput specification);
response.EnsureNoErrors();
var result = response.Data?.UpdateSpecification;
```

### UpsertSpecification

Upserts an LLM specification.

```csharp
var response = await client.UpsertSpecification.ExecuteAsync(SpecificationInput specification);
response.EnsureNoErrors();
var result = response.Data?.UpsertSpecification;
```

### CountUsers

Counts users based on the provided filter criteria.

```csharp
var response = await client.CountUsers.ExecuteAsync(UserFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountUsers;
```

### CreateUser

Creates a new user.

```csharp
var response = await client.CreateUser.ExecuteAsync(UserInput user);
response.EnsureNoErrors();
var result = response.Data?.CreateUser;
```

### DeleteUser

Deletes a user.

```csharp
var response = await client.DeleteUser.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteUser;
```

### DisableUser

Disables a user.

```csharp
var response = await client.DisableUser.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DisableUser;
```

### EnableUser

Enables a user.

```csharp
var response = await client.EnableUser.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.EnableUser;
```

### GetUser

```csharp
var response = await client.GetUser.ExecuteAsync();
response.EnsureNoErrors();
var result = response.Data?.GetUser;
```

### GetUserByIdentifier

```csharp
var response = await client.GetUserByIdentifier.ExecuteAsync(string identifier);
response.EnsureNoErrors();
var result = response.Data?.GetUserByIdentifier;
```

### QueryUsers

```csharp
var response = await client.QueryUsers.ExecuteAsync(UserFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryUsers;
```

### UpdateUser

Updates an existing user.

```csharp
var response = await client.UpdateUser.ExecuteAsync(UserUpdateInput user);
response.EnsureNoErrors();
var result = response.Data?.UpdateUser;
```

### CountViews

Counts views based on the provided filter criteria.

```csharp
var response = await client.CountViews.ExecuteAsync(ViewFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountViews;
```

### CreateView

Creates a new view.

```csharp
var response = await client.CreateView.ExecuteAsync(ViewInput view);
response.EnsureNoErrors();
var result = response.Data?.CreateView;
```

### DeleteAllViews

Bulk deletes views based on the provided filter criteria.

```csharp
var response = await client.DeleteAllViews.ExecuteAsync(ViewFilter? filter, bool? isSynchronous, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllViews;
```

### DeleteView

Deletes a view.

```csharp
var response = await client.DeleteView.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteView;
```

### DeleteViews

Bulk deletes views.

```csharp
var response = await client.DeleteViews.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteViews;
```

### GetView

```csharp
var response = await client.GetView.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetView;
```

### QueryViews

```csharp
var response = await client.QueryViews.ExecuteAsync(ViewFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryViews;
```

### UpdateView

Updates an existing view.

```csharp
var response = await client.UpdateView.ExecuteAsync(ViewUpdateInput view);
response.EnsureNoErrors();
var result = response.Data?.UpdateView;
```

### UpsertView

Upserts a view.

```csharp
var response = await client.UpsertView.ExecuteAsync(ViewInput view);
response.EnsureNoErrors();
var result = response.Data?.UpsertView;
```

### ViewExists

Returns whether any view exists based on the provided filter criteria.

```csharp
var response = await client.ViewExists.ExecuteAsync(ViewFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.ViewExists;
```

### CountWorkflows

Counts workflows based on the provided filter criteria.

```csharp
var response = await client.CountWorkflows.ExecuteAsync(WorkflowFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.CountWorkflows;
```

### CreateWorkflow

Creates a new content workflow.

```csharp
var response = await client.CreateWorkflow.ExecuteAsync(WorkflowInput workflow);
response.EnsureNoErrors();
var result = response.Data?.CreateWorkflow;
```

### DeleteAllWorkflows

Bulk deletes workflows based on the provided filter criteria.

```csharp
var response = await client.DeleteAllWorkflows.ExecuteAsync(
    WorkflowFilter? filter,
    bool? isSynchronous,
    string? correlationId
);
response.EnsureNoErrors();
var result = response.Data?.DeleteAllWorkflows;
```

### DeleteWorkflow

Deletes a content workflow.

```csharp
var response = await client.DeleteWorkflow.ExecuteAsync(string id);
response.EnsureNoErrors();
var result = response.Data?.DeleteWorkflow;
```

### DeleteWorkflows

Deletes multiple workflows given their IDs.

```csharp
var response = await client.DeleteWorkflows.ExecuteAsync(IReadOnlyList<string> ids, bool? isSynchronous);
response.EnsureNoErrors();
var result = response.Data?.DeleteWorkflows;
```

### GetWorkflow

```csharp
var response = await client.GetWorkflow.ExecuteAsync(string id, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.GetWorkflow;
```

### QueryWorkflows

```csharp
var response = await client.QueryWorkflows.ExecuteAsync(WorkflowFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.QueryWorkflows;
```

### UpdateWorkflow

Updates an existing content workflow.

```csharp
var response = await client.UpdateWorkflow.ExecuteAsync(WorkflowUpdateInput workflow);
response.EnsureNoErrors();
var result = response.Data?.UpdateWorkflow;
```

### UpsertWorkflow

Upserts a content workflow.

```csharp
var response = await client.UpsertWorkflow.ExecuteAsync(WorkflowInput workflow);
response.EnsureNoErrors();
var result = response.Data?.UpsertWorkflow;
```

### WorkflowExists

Returns whether any workflow exists based on the provided filter criteria.

```csharp
var response = await client.WorkflowExists.ExecuteAsync(WorkflowFilter? filter, string? correlationId);
response.EnsureNoErrors();
var result = response.Data?.WorkflowExists;
```

## Input Types

### AzureTextExtractionPropertiesInput
Represents an Azure Cognitive Services text entity extraction connector.

```graphql
  enablePII: Boolean
  confidenceThreshold: Float
```

### PromptClassificationRuleInput
Represents the LLM prompt content classification rule.

```graphql
  if: String
  then: String
```

### AttioCRMFeedPropertiesInput
Represents Attio CRM feed properties.

```graphql
  authenticationType: AttioAuthenticationTypes
  apiKey: String
```

### PlaceFacetInput
Represents the configuration for place facet.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: PlaceFacetTypes
```

### UserUpdateInput
Represents a user.

```graphql
  id: ID!
  name: String
  type: UserTypes
  identifier: String
  description: String
```

### AnthropicModelPropertiesInput
Represents Anthropic model properties.

```graphql
  model: AnthropicModels!
  modelName: String
  key: String
  temperature: Float
  probability: Float
  tokenLimit: Int
  chunkTokenLimit: Int
  completionTokenLimit: Int
  enableThinking: Boolean
  thinkingTokenLimit: Int
```

### PointFilter
Filter by geospatial point (i.e. latitude, longitude) and distance radius.

```graphql
  latitude: Float!
  longitude: Float!
  distance: Float
```

### MedicalIndicationFilter
Represents a filter for medical indications.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarIndications: [EntityReferenceFilter!]
  medicalIndications: [EntityReferenceFilter!]
```

### SoftwareFilter
Represents a filter for software.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarSoftwares: [EntityReferenceFilter!]
  softwares: [EntityReferenceFilter!]
```

### MedicalTestInput
Represents a medical test.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### PullRequestFeedPropertiesUpdateInput
Represents pull request feed properties.

```graphql
  github: GitHubPullRequestsFeedPropertiesUpdateInput
  readLimit: Int
```

### MedicalStudyInput
Represents a medical study.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  address: AddressInput
```

### TwitterFeedPropertiesUpdateInput
Represents Twitter feed properties.

```graphql
  token: String
  type: TwitterListingTypes
  userName: String
  query: String
  includeAttachments: Boolean
  readLimit: Int
```

### MedicalTestFilter
Represents a filter for medical tests.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarTests: [EntityReferenceFilter!]
  medicalTests: [EntityReferenceFilter!]
```

### PromptStrategyInput
Represents a prompt strategy.

```graphql
  type: PromptStrategyTypes
```

### MedicalStudyFilter
Represents a filter for medical studies.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarStudies: [EntityReferenceFilter!]
  medicalStudies: [EntityReferenceFilter!]
```

### ConnectorInput
Represents a connector.

```graphql
  name: String!
  type: ConnectorTypes!
  authentication: AuthenticationConnectorInput
  integration: IntegrationConnectorInput
```

### MedicalTestUpdateInput
Represents a medical test.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### InvestmentFundFilter
Represents a filter for investment funds.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarInvestmentFunds: [EntityReferenceFilter!]
  investmentFunds: [EntityReferenceFilter!]
```

### AlertFilter
Represents a filter for alerts.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  types: [AlertTypes!]
```

### BoundingBoxInput
Represents a bounding box.

```graphql
  left: Float
  top: Float
  width: Float
  height: Float
```

### BoxFeedPropertiesInput
Represents Box properties.

```graphql
  authenticationType: BoxAuthenticationTypes
  folderId: ID
  clientId: String
  clientSecret: String
  refreshToken: String
  redirectUri: String
```

### PreparationWorkflowStageInput
Represents the preparation workflow stage.

```graphql
  enableUnblockedCapture: Boolean
  disableSmartCapture: Boolean
  summarizations: [SummarizationStrategyInput]
  jobs: [PreparationWorkflowJobInput]
```

### EmailFeedPropertiesUpdateInput
Represents email feed properties.

```graphql
  includeAttachments: Boolean
  google: GoogleEmailFeedPropertiesUpdateInput
  microsoft: MicrosoftEmailFeedPropertiesUpdateInput
  readLimit: Int
```

### MistralModelPropertiesInput
Represents Mistral model properties.

```graphql
  model: MistralModels!
  modelName: String
  key: String
  endpoint: URL
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
  chunkTokenLimit: Int
```

### PreparationWorkflowJobInput
Represents a preparation workflow job.

```graphql
  connector: FilePreparationConnectorInput
```

### IngestionContentFilterInput
Represents an ingestion content filter.

```graphql
  types: [ContentTypes!]
  fileTypes: [FileTypes!]
  formats: [String]
  fileExtensions: [String!]
  allowedPaths: [String!]
  excludedPaths: [String!]
```

### ProductInput
Represents a product.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  address: AddressInput
  productionDate: DateTime
  releaseDate: DateTime
  sku: String
  upc: String
  manufacturer: String
  brand: String
  model: String
  gtin: String
  mpn: String
```

### MedicalDrugClassInput
Represents a medical drug class.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### MicrosoftContactsCRMFeedPropertiesInput
Represents Microsoft Contacts CRM feed properties.

```graphql
  authenticationType: MicrosoftContactsAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  tenantId: String
  connector: EntityReferenceInput
```

### RSSFeedPropertiesUpdateInput
Represents RSS feed properties.

```graphql
  readLimit: Int
```

### RepoUpdateInput
Represents a code repository.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### MedicalTherapyUpdateInput
Represents a medical therapy.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### MedicalIndicationUpdateInput
Represents a medical indication.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### AttioFeedPropertiesUpdateInput
Represents Attio feed properties.

```graphql
  apiKey: String
  readLimit: Int
```

### MedicalProcedureUpdateInput
Represents a medical procedure.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### CerebrasModelPropertiesUpdateInput
Represents Cerebras model properties.

```graphql
  model: CerebrasModels
  modelName: String
  key: String
  endpoint: URL
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
```

### H3Filter
Represents an H3 geospatial filter.

```graphql
  indexes: [H3IndexFilter!]
```

### ParallelPublishingPropertiesInput
Represents the Parallel research publishing properties.

```graphql
  processor: ParallelProcessors
```

### CategoryFacetInput
Represents the configuration for category facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: CategoryFacetTypes
```

### MedicalDrugInput
Represents a medical drug.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### PersonFacetInput
Represents the configuration for person facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: PersonFacetTypes
```

### ParallelEnrichmentPropertiesInput
Represents Parallel entity enrichment properties.

```graphql
  processor: ParallelProcessors
  isSynchronous: Boolean
```

### WorkflowFilter
Represents a filter for workflows.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
```

### MicrosoftEmailFeedPropertiesUpdateInput
Represents Microsoft Email feed properties.

```graphql
  type: EmailListingTypes
  filter: String
  inboxOnly: Boolean
  includeDeletedItems: Boolean
  excludeSentItems: Boolean
  includeSpam: Boolean
  authenticationType: MicrosoftEmailAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### MedicalTherapyFacetInput
Represents the configuration for medical therapy facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: MedicalTherapyFacetTypes
```

### ClassificationWorkflowStageInput
Represents the classification workflow stage.

```graphql
  jobs: [ClassificationWorkflowJobInput]
```

### ParallelFeedPropertiesUpdateInput
Represents Parallel properties.

```graphql
  processor: ParallelProcessors
```

### ShapeMetadataInput
Represents shape metadata.

```graphql
  creationDate: DateTime
  modifiedDate: DateTime
  location: PointInput
  featureCount: Int
  attributeCount: Int
```

### InvestmentFilter
Represents a filter for investments.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarInvestments: [EntityReferenceFilter!]
  investments: [EntityReferenceFilter!]
```

### SharePointFoldersInput
Represents SharePoint library folders properties.

```graphql
  authenticationType: SharePointAuthenticationTypes!
  tenantId: ID
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### SharePointFeedPropertiesUpdateInput
Represents SharePoint properties.

```graphql
  authenticationType: SharePointAuthenticationTypes
  tenantId: ID
  refreshToken: String
  connector: EntityReferenceInput
  accountName: String
  libraryId: ID
  folderId: ID
```

### ContentPublishingConnectorInput
Represents a content publishing connector.

```graphql
  type: ContentPublishingServiceTypes!
  format: ContentPublishingFormats!
  elevenLabs: ElevenLabsPublishingPropertiesInput
  openAIImage: OpenAIImagePublishingPropertiesInput
  googleImage: GoogleImagePublishingPropertiesInput
  openAIVideo: OpenAIVideoPublishingPropertiesInput
  parallel: ParallelPublishingPropertiesInput
```

### ProjectInput
Represents a project.

```graphql
  name: String!
  environmentType: EnvironmentTypes!
  platform: ResourceConnectorTypes!
  region: String!
  jwtSecret: String!
  quota: ProjectQuotaInput
  callbackUri: URL
```

### InvestmentFundFacetInput
Represents the configuration for investment fund facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: InvestmentFundFacetTypes
```

### PlaceUpdateInput
Represents a place.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  address: AddressInput
  telephone: String
  openingHours: String
  priceRange: String
```

### GoogleFeedPropertiesUpdateInput
Represents Google blob feed properties.

```graphql
  credentials: String
  containerName: String
  prefix: String
```

### CollectionInput
Represents a collection.

```graphql
  name: String!
  type: CollectionTypes
  contents: [EntityReferenceInput!]
  expectedCount: Int
```

### GoogleContactsCRMFeedPropertiesUpdateInput
Represents Google Contacts CRM feed properties.

```graphql
  authenticationType: GoogleContactsAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### EntityClustersInput
Configuration for entity clustering based on embedding similarity.

```graphql
  threshold: Float
```

### EntityReferenceInput
Represents an entity reference.

```graphql
  id: ID!
```

### ImageMetadataInput
Represents image metadata.

```graphql
  creationDate: DateTime
  modifiedDate: DateTime
  location: PointInput
  width: Int
  height: Int
  bitsPerComponent: Int
  components: Int
  projectionType: ImageProjectionTypes
  orientation: OrientationTypes
  resolutionX: Int
  resolutionY: Int
  description: String
  software: String
  identifier: String
  make: String
  model: String
  lens: String
  lensSpecification: String
  focalLength: Float
  exposureTime: String
  fNumber: String
  iso: String
  colorSpace: String
  heading: Float
  pitch: Float
```

### MedicalStudyFacetInput
Represents the configuration for medical study facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: MedicalStudyFacetTypes
```

### IntercomTicketsFeedPropertiesInput
Represents Intercom Tickets feed properties.

```graphql
  accessToken: String!
```

### StorageWorkflowStageInput
Represents the storage workflow stage.

```graphql
  policy: StoragePolicyInput
```

### MedicalDrugFacetInput
Represents the configuration for medical drug facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: MedicalDrugFacetTypes
```

### ConversationUpdateInput
Represents a conversation.

```graphql
  id: ID!
  name: String
  messages: [ConversationMessageInput!]
  tools: [ToolDefinitionInput!]
  specification: EntityReferenceInput
  fallbacks: [EntityReferenceInput]
  filter: ContentCriteriaInput
  augmentedFilter: ContentCriteriaInput
```

### MedicalDrugClassFilter
Represents a filter for medical drug classes.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarClasses: [EntityReferenceFilter!]
  medicalDrugClasses: [EntityReferenceFilter!]
```

### IntercomFeedPropertiesUpdateInput
Represents Intercom feed properties.

```graphql
  accessToken: String
  readLimit: Int
```

### SharePointLibrariesInput
Represents SharePoint libraries properties.

```graphql
  authenticationType: SharePointAuthenticationTypes!
  tenantId: ID
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### MedicalContraindicationFilter
Represents a filter for medical contraindications.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarContraindications: [EntityReferenceFilter!]
  medicalContraindications: [EntityReferenceFilter!]
```

### GitHubFeedPropertiesInput
Represents GitHub properties.

```graphql
  authenticationType: GitHubAuthenticationTypes
  repositoryOwner: String!
  repositoryName: String!
  uri: URL
  clientId: String
  clientSecret: String
  refreshToken: String
  personalAccessToken: String
  connector: EntityReferenceInput
```

### DeepgramAudioPreparationPropertiesInput
Represents the Deepgram preparation properties.

```graphql
  model: DeepgramModels
  key: String
  enableRedaction: Boolean
  enableSpeakerDiarization: Boolean
  detectLanguage: Boolean
  language: String
```

### Int64RangeFilter
Represents a filter by range of long integer values.

```graphql
  from: Long
  to: Long
```

### ConversationMessageInput
Represents a conversation message.

```graphql
  role: ConversationRoleTypes!
  author: String
  message: String!
  tokens: Int
  throughput: Float
  ttft: TimeSpan
  completionTime: TimeSpan
  timestamp: DateTime
  data: String
  mimeType: String
```

### MedicalConditionUpdateInput
Represents a medical condition.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### OpenAIImagePublishingPropertiesInput
Represents the OpenAI Image publishing properties.

```graphql
  model: OpenAIImageModels
  count: Int
  seed: EntityReferenceInput
```

### ViewInput
Represents a view.

```graphql
  name: String!
  type: ViewTypes
  filter: ContentCriteriaInput
  augmentedFilter: ContentCriteriaInput
```

### ProductFilter
Represents a filter for products.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  productionDateRange: DateRangeFilter
  releaseDateRange: DateRangeFilter
  sku: String
  upc: String
  manufacturer: String
  brand: String
  model: String
  similarProducts: [EntityReferenceFilter!]
  products: [EntityReferenceFilter!]
```

### JinaModelPropertiesInput
Represents Jina model properties.

```graphql
  model: JinaModels!
  modelName: String
  key: String
  chunkTokenLimit: Int
```

### EmailMetadataInput
Represents email metadata.

```graphql
  creationDate: DateTime
  modifiedDate: DateTime
  location: PointInput
  subject: String
  identifier: String
  threadIdentifier: String
  sensitivity: MailSensitivity
  priority: MailPriority
  importance: MailImportance
  labels: [String]
  links: [URL]
  attachmentCount: Int
  unsubscribeUrl: String
  publicationName: String
  publicationUrl: String
```

### ViewUpdateInput
Represents a view.

```graphql
  id: ID!
  name: String
  type: ViewTypes
  filter: ContentCriteriaInput
  augmentedFilter: ContentCriteriaInput
```

### PersonInput
Represents a person.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  address: AddressInput
  givenName: String
  familyName: String
  phoneNumber: String
  email: String
  birthDate: Date
  title: String
  occupation: String
  education: String
```

### VoyageModelPropertiesUpdateInput
Represents Voyage model properties.

```graphql
  model: VoyageModels
  modelName: String
  key: String
  chunkTokenLimit: Int
```

### PackageMetadataInput
Represents package metadata.

```graphql
  creationDate: DateTime
  modifiedDate: DateTime
  location: PointInput
  fileCount: Int
  folderCount: Int
```

### PointCloudMetadataInput
Represents point cloud metadata.

```graphql
  creationDate: DateTime
  modifiedDate: DateTime
  location: PointInput
  software: String
  description: String
  identifier: String
  pointCount: Long
```

### AttioCRMFeedPropertiesUpdateInput
Represents Attio CRM feed properties.

```graphql
  authenticationType: AttioAuthenticationTypes
  apiKey: String
```

### MicrosoftTeamsChannelsInput
Represents Microsoft Teams team channels properties.

```graphql
  authenticationType: MicrosoftTeamsAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### InvestmentFundInput
Represents an investment fund.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  amountCurrency: String
  amount: Decimal
  fundType: String
  vintage: Int
  targetSize: Decimal
  targetSizeCurrency: String
```

### OpenAIVideoPublishingPropertiesInput
Represents the OpenAI Video publishing properties.

```graphql
  model: OpenAIVideoModels
  seconds: Int
  size: VideoSizeTypes
  seed: EntityReferenceInput
```

### ModelDocumentPreparationPropertiesInput
Represents the LLM document preparation properties.

```graphql
  specification: EntityReferenceInput
```

### ProjectFilter
Represents a filter for projects.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
```

### ToolDefinitionInput
Represents a tool definition.

```graphql
  name: String!
  description: String
  schema: String!
```

### H3IndexFilter
Represents an H3 geospatial index filter.

```graphql
  resolution: H3ResolutionTypes
  key: String
```

### GitHubPullRequestsFeedPropertiesInput
Represents GitHub Pull Requests feed properties.

```graphql
  authenticationType: GitHubPullRequestAuthenticationTypes
  repositoryOwner: String!
  repositoryName: String!
  uri: URL
  clientId: String
  clientSecret: String
  refreshToken: String
  personalAccessToken: String
  connector: EntityReferenceInput
```

### AzureAIModelPropertiesUpdateInput
Represents Azure AI model properties.

```graphql
  key: String
  endpoint: URL
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
  chunkTokenLimit: Int
```

### MicrosoftCalendarsInput
Represents Microsoft Calendar properties.

```graphql
  authenticationType: MicrosoftCalendarAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### ObservationInput
Represents an observation.

```graphql
  content: EntityReferenceInput!
  type: ObservableTypes!
  observable: NamedEntityReferenceInput!
  related: NamedEntityReferenceInput
  relatedType: ObservableTypes
  relation: String
  occurrences: [ObservationOccurrenceInput!]!
```

### AttioTasksFeedPropertiesUpdateInput
Represents Attio Tasks feed properties.

```graphql
  apiKey: String!
```

### ProductUpdateInput
Represents a product.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  address: AddressInput
  productionDate: DateTime
  releaseDate: DateTime
  sku: String
  upc: String
  manufacturer: String
  brand: String
  model: String
  gtin: String
  mpn: String
```

### MedicalTherapyFilter
Represents a filter for medical therapies.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarTherapies: [EntityReferenceFilter!]
  medicalTherapies: [EntityReferenceFilter!]
```

### GoogleDriveFeedPropertiesInput
Represents Google Drive properties.

```graphql
  authenticationType: GoogleDriveAuthenticationTypes
  files: [String]
  folderId: String
  refreshToken: String
  clientId: String
  clientSecret: String
  serviceAccountJson: String
  connector: EntityReferenceInput
```

### InvestmentFundUpdateInput
Represents an investment fund.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  amountCurrency: String
  amount: Decimal
  fundType: String
  vintage: Int
  targetSize: Decimal
  targetSizeCurrency: String
```

### ExtractionWorkflowStageInput
Represents the extraction workflow stage.

```graphql
  jobs: [ExtractionWorkflowJobInput]
```

### MedicalDeviceInput
Represents a medical device.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### WebFeedPropertiesUpdateInput
Represents web feed properties.

```graphql
  uri: URL
  allowedPaths: [String!]
  excludedPaths: [String!]
  includeFiles: Boolean
  readLimit: Int
```

### OpenAIModelPropertiesUpdateInput
Represents OpenAI model properties.

```graphql
  model: OpenAIModels
  modelName: String
  key: String
  endpoint: URL
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
  chunkTokenLimit: Int
  detailLevel: OpenAIVisionDetailLevels
  reasoningEffort: OpenAIReasoningEffortLevels
```

### EnrichmentWorkflowStageInput
Represents the enrichment workflow stage.

```graphql
  link: LinkStrategyInput
  jobs: [EnrichmentWorkflowJobInput]
  entityResolution: EntityResolutionStrategyInput
```

### FeedInput
Represents a feed.

```graphql
  name: String!
  description: String
  type: FeedTypes!
  syncMode: FeedSyncMode
  site: SiteFeedPropertiesInput
  calendar: CalendarFeedPropertiesInput
  email: EmailFeedPropertiesInput
  crm: CRMFeedPropertiesInput
  issue: IssueFeedPropertiesInput
  pullRequest: PullRequestFeedPropertiesInput
  commit: CommitFeedPropertiesInput
  rss: RSSFeedPropertiesInput
  web: WebFeedPropertiesInput
  search: SearchFeedPropertiesInput
  reddit: RedditFeedPropertiesInput
  youtube: YouTubeFeedPropertiesInput
  notion: NotionFeedPropertiesInput
  twitter: TwitterFeedPropertiesInput
  slack: SlackFeedPropertiesInput
  microsoftTeams: MicrosoftTeamsFeedPropertiesInput
  discord: DiscordFeedPropertiesInput
  attio: AttioFeedPropertiesInput
  intercom: IntercomFeedPropertiesInput
  zendesk: ZendeskFeedPropertiesInput
  research: ResearchFeedPropertiesInput
  entity: EntityFeedPropertiesInput
  schedulePolicy: FeedSchedulePolicyInput
  workflow: EntityReferenceInput
```

### ObservationReferenceInput
Represents an observation reference.

```graphql
  type: ObservableTypes!
  observable: NamedEntityReferenceInput!
```

### ModelFilter
Represents a filter for LLM models.

```graphql
  types: [ModelTypes!]
  serviceTypes: [ModelServiceTypes!]
```

### PostMetadataInput
Represents post metadata.

```graphql
  creationDate: DateTime
  modifiedDate: DateTime
  location: PointInput
  identifier: String
  title: String
  author: PersonReferenceInput
  upvotes: Int
  downvotes: Int
  commentCount: Int
  links: [LinkReferenceInput]
```

### ReductoDocumentPreparationPropertiesInput
Represents the Reducto document preparation properties.

```graphql
  ocrMode: ReductoOcrModes
  ocrSystem: ReductoOcrSystems
  extractionMode: ReductoExtractionModes
  enableEnrichment: Boolean
  enrichmentMode: ReductoEnrichmentModes
  key: String
```

### TrelloFeedPropertiesInput
Represents Trello feed properties.

```graphql
  key: String!
  token: String!
  type: TrelloTypes!
  identifiers: [String!]!
```

### RedditFeedPropertiesUpdateInput
Represents Reddit feed properties.

```graphql
  readLimit: Int
```

### AssemblyAIAudioPreparationPropertiesInput
Represents the Assembly.AI preparation properties.

```graphql
  model: AssemblyAIModels
  key: String
  enableRedaction: Boolean
  enableSpeakerDiarization: Boolean
  detectLanguage: Boolean
  language: String
```

### DiscordFeedPropertiesUpdateInput
Represents Discord feed properties.

```graphql
  type: FeedListingTypes
  token: String
  channel: String
  includeAttachments: Boolean
  readLimit: Int
```

### LinearProjectsInput
Represents Linear projects properties.

```graphql
  key: String!
```

### SoftwareUpdateInput
Represents software.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  developer: String
  releaseDate: DateTime
```

### SpecificationInput
Represents an LLM specification.

```graphql
  name: String!
  type: SpecificationTypes
  serviceType: ModelServiceTypes!
  searchType: ConversationSearchTypes
  numberSimilar: Int
  systemPrompt: String
  customGuidance: String
  customInstructions: String
  strategy: ConversationStrategyInput
  promptStrategy: PromptStrategyInput
  retrievalStrategy: RetrievalStrategyInput
  rerankingStrategy: RerankingStrategyInput
  graphStrategy: GraphStrategyInput
  revisionStrategy: RevisionStrategyInput
  azureAI: AzureAIModelPropertiesInput
  openAI: OpenAIModelPropertiesInput
  azureOpenAI: AzureOpenAIModelPropertiesInput
  cohere: CohereModelPropertiesInput
  anthropic: AnthropicModelPropertiesInput
  google: GoogleModelPropertiesInput
  replicate: ReplicateModelPropertiesInput
  mistral: MistralModelPropertiesInput
  bedrock: BedrockModelPropertiesInput
  xai: XAIModelPropertiesInput
  groq: GroqModelPropertiesInput
  cerebras: CerebrasModelPropertiesInput
  deepseek: DeepseekModelPropertiesInput
  jina: JinaModelPropertiesInput
  voyage: VoyageModelPropertiesInput
```

### GitHubCommitsFeedPropertiesInput
Represents GitHub Commits feed properties.

```graphql
  authenticationType: GitHubCommitAuthenticationTypes
  repositoryOwner: String!
  repositoryName: String!
  branch: String
  uri: URL
  clientId: String
  clientSecret: String
  refreshToken: String
  personalAccessToken: String
  connector: EntityReferenceInput
```

### ProjectQuotaInput
Represents the project quota.

```graphql
  storage: Long
  contents: Int
  feeds: Int
  posts: Int
  conversations: Int
```

### UserInput
Represents a user.

```graphql
  name: String!
  type: UserTypes
  identifier: String!
  description: String
```

### AddressInput
Represents an address.

```graphql
  streetAddress: String
  city: String
  region: String
  country: String
  postalCode: String
```

### AzureFileFeedPropertiesUpdateInput
Represents Azure file share feed properties.

```graphql
  storageAccessKey: String
  accountName: String
  shareName: String
  prefix: String
```

### RegexContentClassificationPropertiesInput
Represents the regex content classification properties.

```graphql
  rules: [RegexClassificationRuleInput]
```

### WorkflowActionInput
Represents the workflow action.

```graphql
  connector: IntegrationConnectorInput
```

### VoyageModelPropertiesInput
Represents Voyage model properties.

```graphql
  model: VoyageModels!
  modelName: String
  key: String
  chunkTokenLimit: Int
```

### RepoFacetInput
Represents the configuration for repo facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: RepoFacetTypes
```

### FeedUpdateInput
Represents a feed.

```graphql
  id: ID!
  name: String
  description: String
  type: FeedTypes
  syncMode: FeedSyncMode
  site: SiteFeedPropertiesUpdateInput
  calendar: CalendarFeedPropertiesUpdateInput
  email: EmailFeedPropertiesUpdateInput
  crm: CRMFeedPropertiesUpdateInput
  issue: IssueFeedPropertiesUpdateInput
  pullRequest: PullRequestFeedPropertiesUpdateInput
  commit: CommitFeedPropertiesUpdateInput
  rss: RSSFeedPropertiesUpdateInput
  web: WebFeedPropertiesUpdateInput
  search: SearchFeedPropertiesUpdateInput
  reddit: RedditFeedPropertiesUpdateInput
  youtube: YouTubeFeedPropertiesUpdateInput
  notion: NotionFeedPropertiesUpdateInput
  twitter: TwitterFeedPropertiesUpdateInput
  slack: SlackFeedPropertiesUpdateInput
  microsoftTeams: MicrosoftTeamsFeedPropertiesUpdateInput
  discord: DiscordFeedPropertiesUpdateInput
  attio: AttioFeedPropertiesUpdateInput
  intercom: IntercomFeedPropertiesUpdateInput
  zendesk: ZendeskFeedPropertiesUpdateInput
  research: ResearchFeedPropertiesUpdateInput
  entity: EntityFeedPropertiesUpdateInput
  schedulePolicy: FeedSchedulePolicyInput
  workflow: EntityReferenceInput
```

### MedicalDeviceFacetInput
Represents the configuration for medical device facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: MedicalDeviceFacetTypes
```

### ContentFacetInput
Represents the configuration for retrieving the content facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: ContentFacetTypes
```

### SharePointFeedPropertiesInput
Represents SharePoint properties.

```graphql
  authenticationType: SharePointAuthenticationTypes!
  tenantId: ID
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
  accountName: String!
  libraryId: ID!
  folderId: ID
```

### MedicalContraindicationUpdateInput
Represents a medical contraindication.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### ConversationStrategyInput
Represents a conversation strategy.

```graphql
  type: ConversationStrategyTypes
  messageLimit: Int
  embedCitations: Boolean
  flattenCitations: Boolean
  enableFacets: Boolean
  messagesWeight: Float
  contentsWeight: Float
```

### ModelImageExtractionPropertiesInput
Represents an LLM image entity extraction connector.

```graphql
  specification: EntityReferenceInput
```

### ParallelFeedPropertiesInput
Represents Parallel properties.

```graphql
  processor: ParallelProcessors
```

### GoogleFeedPropertiesInput
Represents Google blob feed properties.

```graphql
  credentials: String!
  containerName: String!
  prefix: String
```

### MicrosoftCalendarFeedPropertiesUpdateInput
Represents Microsoft Calendar properties.

```graphql
  type: CalendarListingTypes
  calendarId: String
  beforeDate: DateTime
  afterDate: DateTime
  authenticationType: MicrosoftCalendarAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### CollectionUpdateInput
Represents a collection.

```graphql
  id: ID!
  name: String
  type: CollectionTypes
  contents: [EntityReferenceInput!]
  expectedCount: Int
```

### EntityFeedPropertiesUpdateInput
Represents entity discovery feed properties.

```graphql
  query: String
  parallel: ParallelEntityFeedPropertiesUpdateInput
  readLimit: Int
```

### MedicalDeviceFilter
Represents a filter for medical devices.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarDevices: [EntityReferenceFilter!]
  medicalDevices: [EntityReferenceFilter!]
```

### GitHubIssuesFeedPropertiesUpdateInput
Represents GitHub Issues feed properties.

```graphql
  repositoryOwner: String
  repositoryName: String
  uri: URL
  clientId: String
  clientSecret: String
  refreshToken: String
  personalAccessToken: String
```

### ZendeskTicketsFeedPropertiesInput
Represents Zendesk Tickets feed properties.

```graphql
  subdomain: String!
  accessToken: String!
```

### AtlassianJiraFeedPropertiesUpdateInput
Represents Atlassian Jira feed properties.

```graphql
  uri: URL
  project: String
  email: String
  token: String
  offset: TimeSpan
```

### CalendarAttendeeInput
Represents a calendar event attendee input.

```graphql
  name: String
  email: String
  displayName: String
  isOptional: Boolean
  isOrganizer: Boolean
  isRequired: Boolean
  isResource: Boolean
  responseStatus: CalendarAttendeeResponseStatus
```

### CommitFeedPropertiesInput
Represents commit feed properties.

```graphql
  type: FeedServiceTypes!
  github: GitHubCommitsFeedPropertiesInput
  readLimit: Int
```

### MicrosoftEmailFeedPropertiesInput
Represents Microsoft Email feed properties.

```graphql
  type: EmailListingTypes
  filter: String
  inboxOnly: Boolean
  includeDeletedItems: Boolean
  excludeSentItems: Boolean
  includeSpam: Boolean
  authenticationType: MicrosoftEmailAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### ParallelEntityFeedPropertiesInput
Parallel-specific entity discovery properties.

```graphql
  generator: ParallelGenerators
```

### GitHubPullRequestsFeedPropertiesUpdateInput
Represents GitHub Pull Requests feed properties.

```graphql
  authenticationType: GitHubPullRequestAuthenticationTypes
  repositoryOwner: String
  repositoryName: String
  uri: URL
  clientId: String
  clientSecret: String
  refreshToken: String
  personalAccessToken: String
  connector: EntityReferenceInput
```

### InvestmentFacetInput
Represents the configuration for investment facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: InvestmentFacetTypes
```

### Int64RangeInput
Represents a range of long integer values.

```graphql
  from: Long
  to: Long
```

### ObservationCriteriaInput
Represents an observation filter.

```graphql
  type: ObservableTypes
  observable: EntityReferenceInput
  states: [EntityState!]
```

### IntegrationConnectorUpdateInput
Represents an integration connector.

```graphql
  serviceType: IntegrationServiceTypes!
  uri: String
  slack: SlackIntegrationPropertiesInput
  email: EmailIntegrationPropertiesInput
  twitter: TwitterIntegrationPropertiesInput
  mcp: MCPIntegrationPropertiesInput
```

### MicrosoftTeamsFeedPropertiesUpdateInput
Represents Microsoft Teams feed properties.

```graphql
  type: FeedListingTypes
  authenticationType: MicrosoftTeamsAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
  teamId: String!
  channelId: String!
  includeAttachments: Boolean
  readLimit: Int
```

### AnthropicModelPropertiesUpdateInput
Represents Anthropic model properties.

```graphql
  model: AnthropicModels
  modelName: String
  key: String
  temperature: Float
  probability: Float
  tokenLimit: Int
  chunkTokenLimit: Int
  completionTokenLimit: Int
  enableThinking: Boolean
  thinkingTokenLimit: Int
```

### BoxFoldersInput
Represents Box folders properties.

```graphql
  authenticationType: BoxAuthenticationTypes
  clientId: String
  clientSecret: String
  redirectUri: String
  refreshToken: String
```

### ContentCriteriaLevelInput
Represents a filter level for contents.

```graphql
  feeds: [EntityReferenceInput!]
  workflows: [EntityReferenceInput!]
  collections: [EntityReferenceInput!]
  observations: [ObservationCriteriaInput!]
```

### OneDriveFoldersInput
Represents OneDrive folders properties.

```graphql
  authenticationType: OneDriveAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### MedicalTherapyInput
Represents a medical therapy.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### ContentCriteriaInput
Represents a content filter.

```graphql
  inLast: TimeSpan
  dateRange: DateRangeInput
  createdInLast: TimeSpan
  creationDateRange: DateRangeInput
  types: [ContentTypes!]
  fileTypes: [FileTypes!]
  formats: [String]
  fileExtensions: [String!]
  fileSizeRange: Int64RangeInput
  similarContents: [EntityReferenceInput!]
  contents: [EntityReferenceInput!]
  feeds: [EntityReferenceInput!]
  workflows: [EntityReferenceInput!]
  collections: [EntityReferenceInput!]
  observations: [ObservationCriteriaInput!]
  or: [ContentCriteriaLevelInput!]
  and: [ContentCriteriaLevelInput!]
  hasObservations: Boolean
  hasFeeds: Boolean
  hasCollections: Boolean
  hasWorkflows: Boolean
  collectionMode: FilterMode
  observationMode: FilterMode
```

### ObservationReferenceFilter
Represents a filter for observations.

```graphql
  type: ObservableTypes!
  observable: EntityReferenceFilter!
  states: [EntityState!]
```

### IngestionWorkflowStageInput
Represents the ingestion workflow stage.

```graphql
  if: IngestionContentFilterInput
  collections: [EntityReferenceInput]
  observations: [ObservationReferenceInput]
  enableEmailCollections: Boolean
  enableFolderCollections: Boolean
  enableMessageCollections: Boolean
```

### RSSFeedPropertiesInput
Represents RSS feed properties.

```graphql
  uri: URL!
  readLimit: Int
```

### RevisionStrategyInput
Represents a revision strategy.

```graphql
  type: RevisionStrategyTypes
  customRevision: String
  count: Int
```

### OneDriveFeedPropertiesInput
Represents OneDrive properties.

```graphql
  authenticationType: OneDriveAuthenticationTypes
  files: [ID]
  folderId: ID
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### MicrosoftTeamsFeedPropertiesInput
Represents Microsoft Teams feed properties.

```graphql
  type: FeedListingTypes
  authenticationType: MicrosoftTeamsAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
  teamId: String!
  channelId: String!
  includeAttachments: Boolean
  readLimit: Int
```

### ArcadeAuthenticationPropertiesInput
Represents Arcade authentication properties.

```graphql
  authorizationId: String!
  provider: ArcadeProviders!
  metadata: String
```

### GoogleModelPropertiesInput
Represents Google model properties.

```graphql
  model: GoogleModels!
  modelName: String
  key: String
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
  chunkTokenLimit: Int
  enableThinking: Boolean
  thinkingTokenLimit: Int
```

### CRMFeedPropertiesUpdateInput
Represents entity feed properties.

```graphql
  attio: AttioCRMFeedPropertiesUpdateInput
  googleContacts: GoogleContactsCRMFeedPropertiesUpdateInput
  microsoftContacts: MicrosoftContactsCRMFeedPropertiesUpdateInput
  readLimit: Int
```

### MedicalDrugUpdateInput
Represents a medical drug.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### SiteFeedPropertiesUpdateInput
Represents site feed properties.

```graphql
  isRecursive: Boolean
  allowedPaths: [String!]
  excludedPaths: [String!]
  s3: AmazonFeedPropertiesUpdateInput
  azureBlob: AzureBlobFeedPropertiesUpdateInput
  azureFile: AzureFileFeedPropertiesUpdateInput
  google: GoogleFeedPropertiesUpdateInput
  sharePoint: SharePointFeedPropertiesUpdateInput
  oneDrive: OneDriveFeedPropertiesUpdateInput
  googleDrive: GoogleDriveFeedPropertiesUpdateInput
  github: GitHubFeedPropertiesUpdateInput
  dropbox: DropboxFeedPropertiesUpdateInput
  box: BoxFeedPropertiesUpdateInput
  readLimit: Int
```

### AlertUpdateInput
Represents an alert.

```graphql
  id: ID!
  name: String
  summaryPrompt: String
  publishPrompt: String
  view: EntityReferenceInput
  filter: ContentCriteriaInput
  publishing: ContentPublishingConnectorUpdateInput
  integration: IntegrationConnectorUpdateInput
  summarySpecification: EntityReferenceInput
  publishSpecification: EntityReferenceInput
  schedulePolicy: AlertSchedulePolicyInput
```

### DeepseekModelPropertiesUpdateInput
Represents Deepseek model properties.

```graphql
  model: DeepseekModels
  modelName: String
  key: String
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
```

### RegexClassificationRuleInput
Represents the regex prompt content classification rule.

```graphql
  type: RegexSourceTypes
  path: String
  matches: String
  then: String
```

### ZendeskTicketsFeedPropertiesUpdateInput
Represents Zendesk Tickets feed properties.

```graphql
  subdomain: String
  accessToken: String
```

### GroqModelPropertiesInput
Represents Groq model properties.

```graphql
  model: GroqModels!
  modelName: String
  key: String
  endpoint: URL
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
```

### AzureOpenAIModelPropertiesUpdateInput
Represents Azure OpenAI model properties.

```graphql
  model: AzureOpenAIModels
  deploymentName: String
  key: String
  endpoint: URL
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
  chunkTokenLimit: Int
```

### ConnectorUpdateInput
Represents a connector.

```graphql
  id: ID!
  name: String
  authentication: AuthenticationConnectorInput
  integration: IntegrationConnectorInput
```

### ModelContentClassificationPropertiesInput
Represents the model content classification properties.

```graphql
  specification: EntityReferenceInput
  rules: [PromptClassificationRuleInput]
```

### DiscordChannelsInput
Represents Discord channels properties.

```graphql
  token: String!
  guildId: String!
```

### DocumentPreparationPropertiesInput
Represents the document preparation properties.

```graphql
  includeImages: Boolean
```

### GoogleCalendarsInput
Represents Google Calendar properties.

```graphql
  authenticationType: GoogleCalendarAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### PersonUpdateInput
Represents a person.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  address: AddressInput
  givenName: String
  familyName: String
  phoneNumber: String
  email: String
  birthDate: Date
  title: String
  occupation: String
  education: String
```

### MicrosoftAuthenticationPropertiesInput
Represents Microsoft authentication properties.

```graphql
  tenantId: ID!
  clientId: String!
  clientSecret: String!
```

### ReplicateModelPropertiesInput
Represents Replicate model properties.

```graphql
  model: ReplicateModels!
  modelName: String
  key: String
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
```

### SiteFeedPropertiesInput
Represents site feed properties.

```graphql
  type: FeedServiceTypes!
  isRecursive: Boolean
  allowedPaths: [String!]
  excludedPaths: [String!]
  s3: AmazonFeedPropertiesInput
  azureBlob: AzureBlobFeedPropertiesInput
  azureFile: AzureFileFeedPropertiesInput
  google: GoogleFeedPropertiesInput
  sharePoint: SharePointFeedPropertiesInput
  oneDrive: OneDriveFeedPropertiesInput
  googleDrive: GoogleDriveFeedPropertiesInput
  github: GitHubFeedPropertiesInput
  dropbox: DropboxFeedPropertiesInput
  box: BoxFeedPropertiesInput
  readLimit: Int
```

### IntercomFeedPropertiesInput
Represents Intercom feed properties.

```graphql
  accessToken: String!
  readLimit: Int
```

### NotionDatabasesInput
Represents Notion databases properties.

```graphql
  token: String!
```

### ModelTextExtractionPropertiesInput
Represents an LLM text entity extraction connector.

```graphql
  specification: EntityReferenceInput
  tokenThreshold: Int
  timeBudget: TimeSpan
  entityBudget: Int
```

### PersonReferenceInput
Represents a person reference input.

```graphql
  name: String
  givenName: String
  familyName: String
  email: String
```

### AtlassianJiraFeedPropertiesInput
Represents Atlassian Jira feed properties.

```graphql
  uri: URL!
  project: String!
  email: String!
  token: String!
  offset: TimeSpan
```

### ResearchFeedPropertiesUpdateInput
Represents Research feed properties.

```graphql
  type: FeedServiceTypes
  query: String
  parallel: ParallelFeedPropertiesUpdateInput
  readLimit: Int
```

### OrganizationUpdateInput
Represents an organization.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  address: AddressInput
  foundingDate: DateTime
  email: String
  telephone: String
  legalName: String
  industries: [String]
  revenueCurrency: String
  revenue: Decimal
  investmentCurrency: String
  investment: Decimal
```

### GoogleAuthenticationPropertiesInput
Represents Google authentication properties.

```graphql
  clientId: String!
  clientSecret: String!
```

### NotionPagesInput
Represents Notion pages properties.

```graphql
  token: String!
```

### UserFilter
Represents a filter for users.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  identifier: String
```

### CalendarRecurrenceInput
Represents a calendar event recurrence input.

```graphql
  pattern: CalendarRecurrencePattern
  interval: Int
  count: Int
  until: DateTime
  daysOfWeek: [String]
  dayOfMonth: Int
  monthOfYear: Int
```

### XAIModelPropertiesUpdateInput
Represents xAI model properties.

```graphql
  model: XAIModels
  modelName: String
  key: String
  endpoint: URL
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
```

### OpenAIModelPropertiesInput
Represents OpenAI model properties.

```graphql
  model: OpenAIModels!
  modelName: String
  key: String
  endpoint: URL
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
  chunkTokenLimit: Int
  detailLevel: OpenAIVisionDetailLevels
  reasoningEffort: OpenAIReasoningEffortLevels
```

### EntityResolutionStrategyInput
Represents the entity resolution strategy for automatic duplicate detection and merging.

```graphql
  strategy: EntityResolutionStrategyTypes
  threshold: Float
  specification: EntityReferenceInput
```

### BedrockModelPropertiesUpdateInput
Represents Amazon Bedrock model properties.

```graphql
  model: BedrockModels
  modelName: String
  accessKey: String
  secretAccessKey: String
  endpoint: URL
  region: String
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
```

### BoxFeedPropertiesUpdateInput
Represents Box properties.

```graphql
  authenticationType: BoxAuthenticationTypes
  folderId: ID
  clientId: String
  clientSecret: String
  refreshToken: String
  redirectUri: String
```

### StoragePolicyInput
Represents the storage policy.

```graphql
  type: StoragePolicyTypes
  allowDuplicates: Boolean
  embeddingTypes: [EmbeddingTypes!]
  enableSnapshots: Boolean
  snapshotCount: Int
```

### LanguageMetadataInput
Represents language metadata.

```graphql
  languages: [String]
```

### MedicalContraindicationFacetInput
Represents the configuration for medical contraindication facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: MedicalContraindicationFacetTypes
```

### CohereModelPropertiesInput
Represents Cohere model properties.

```graphql
  model: CohereModels!
  modelName: String
  key: String
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
  chunkTokenLimit: Int
```

### AzureImageExtractionPropertiesInput
Represents an Azure Cognitive Services image entity extraction connector.

```graphql
  confidenceThreshold: Float
```

### CategoryUpdateInput
Represents a category.

```graphql
  id: ID!
  name: String
  description: String
```

### ConnectorFilter
Represents a filter for connectors.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  types: [ConnectorTypes!]
```

### MedicalGuidelineFilter
Represents a filter for medical guidelines.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarGuidelines: [EntityReferenceFilter!]
  medicalGuidelines: [EntityReferenceFilter!]
```

### JinaModelPropertiesUpdateInput
Represents Jina model properties.

```graphql
  model: JinaModels
  modelName: String
  key: String
  chunkTokenLimit: Int
```

### OAuthAuthenticationPropertiesInput
Represents OAuth authentication properties.

```graphql
  provider: OAuthProviders!
  clientId: String!
  clientSecret: String!
  refreshToken: String!
  metadata: String
```

### GitHubCommitsFeedPropertiesUpdateInput
Represents GitHub Commits feed properties.

```graphql
  authenticationType: GitHubCommitAuthenticationTypes
  repositoryOwner: String
  repositoryName: String
  branch: String
  uri: URL
  clientId: String
  clientSecret: String
  refreshToken: String
  personalAccessToken: String
  connector: EntityReferenceInput
```

### EntityEnrichmentConnectorInput
Represents an entity enrichment connector.

```graphql
  type: EntityEnrichmentServiceTypes!
  enrichedTypes: [ObservableTypes!]
  parallel: ParallelEnrichmentPropertiesInput
  fhir: FHIREnrichmentPropertiesInput
  diffbot: DiffbotEnrichmentPropertiesInput
```

### GitHubRepositoriesInput
Represents GitHub repositories properties.

```graphql
  authenticationType: GitHubAuthenticationTypes!
  uri: String
  personalAccessToken: String
  refreshToken: String
  connector: EntityReferenceInput
```

### NotionFeedPropertiesUpdateInput
Represents Notion feed properties.

```graphql
  isRecursive: Boolean
  token: String!
  type: NotionTypes
  identifiers: [String!]
  readLimit: Int
```

### EmailFeedPropertiesInput
Represents email feed properties.

```graphql
  type: FeedServiceTypes!
  includeAttachments: Boolean
  google: GoogleEmailFeedPropertiesInput
  microsoft: MicrosoftEmailFeedPropertiesInput
  readLimit: Int
```

### ExtractionWorkflowJobInput
Represents an extraction workflow job.

```graphql
  connector: EntityExtractionConnectorInput
```

### GraphInput
Configuration for knowledge graph retrieval.

```graphql
  types: [ObservableTypes!]
```

### ZendeskFeedPropertiesInput
Represents Zendesk feed properties.

```graphql
  subdomain: String!
  accessToken: String!
  readLimit: Int
```

### GoogleContactsCRMFeedPropertiesInput
Represents Google Contacts CRM feed properties.

```graphql
  authenticationType: GoogleContactsAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### MedicalConditionFilter
Represents a filter for medical conditions.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarConditions: [EntityReferenceFilter!]
  medicalConditions: [EntityReferenceFilter!]
```

### ConversationToolResponseInput
Represents a conversation tool calling response.

```graphql
  id: String!
  content: String!
```

### OneDriveFeedPropertiesUpdateInput
Represents OneDrive properties.

```graphql
  authenticationType: OneDriveAuthenticationTypes
  files: [ID]
  folderId: ID
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### NamedEntityReferenceInput
Represents a named entity reference.

```graphql
  id: ID
  name: String
```

### DrawingMetadataInput
Represents drawing metadata.

```graphql
  creationDate: DateTime
  modifiedDate: DateTime
  location: PointInput
  x: Float
  y: Float
  width: Float
  height: Float
  depth: Float
  unitType: UnitTypes
```

### AzureBlobFeedPropertiesInput
Represents Azure blob feed properties.

```graphql
  storageAccessKey: String!
  accountName: String!
  containerName: String!
  prefix: String
  listType: BlobListingTypes
```

### LinkStrategyInput
Represents the content hyperlink strategy.

```graphql
  enableCrawling: Boolean
  allowedPaths: [String!]
  excludedPaths: [String!]
  allowedDomains: [String!]
  excludedDomains: [String!]
  allowContentDomain: Boolean
  allowedLinks: [LinkTypes!]
  excludedLinks: [LinkTypes!]
  allowedFiles: [FileTypes!]
  excludedFiles: [FileTypes!]
  allowedContentTypes: [ContentTypes!]
  excludedContentTypes: [ContentTypes!]
  maximumLinks: Int
```

### MicrosoftTeamsTeamsInput
Represents Microsoft Teams teams properties.

```graphql
  authenticationType: MicrosoftTeamsAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### InvestmentInput
Represents an investment.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  amountCurrency: String
  amount: Decimal
  status: String
  stage: String
  investmentDate: DateTime
  roundSize: Decimal
  roundSizeCurrency: String
  postValuation: Decimal
  postValuationCurrency: String
  sharesOwned: Decimal
  vehicle: String
  entryPricePerShare: Decimal
  currentPricePerShare: Decimal
  discountPercent: Decimal
  proRataRights: Boolean
  investor: EntityReferenceInput
  organization: EntityReferenceInput
```

### TwitterIntegrationPropertiesInput
Represents Twitter integration properties.

```graphql
  consumerKey: String!
  consumerSecret: String!
  accessTokenKey: String!
  accessTokenSecret: String!
```

### EmailPreparationPropertiesInput
Represents the email preparation properties.

```graphql
  includeAttachments: Boolean
```

### YouTubeFeedPropertiesUpdateInput
Represents YouTube feed properties.

```graphql
  type: YouTubeTypes
  videoName: String
  videoIdentifiers: [String!]
  channelIdentifier: String
  playlistIdentifier: String
  readLimit: Int
```

### CalendarFeedPropertiesUpdateInput
Represents calendar feed properties.

```graphql
  includeAttachments: Boolean
  enableMeetingRecording: Boolean
  meetingBotName: String
  google: GoogleCalendarFeedPropertiesUpdateInput
  microsoft: MicrosoftCalendarFeedPropertiesUpdateInput
  readLimit: Int
```

### MedicalConditionFacetInput
Represents the configuration for medical condition facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: MedicalConditionFacetTypes
```

### VideoMetadataInput
Represents video metadata.

```graphql
  creationDate: DateTime
  modifiedDate: DateTime
  location: PointInput
  width: Int
  height: Int
  duration: String
  software: String
  make: String
  model: String
```

### ParallelEntityFeedPropertiesUpdateInput
Parallel-specific entity discovery properties.

```graphql
  generator: ParallelGenerators
```

### LabelFacetInput
Represents the configuration for label facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: LabelFacetTypes
```

### MistralDocumentPreparationPropertiesInput
Represents the Mistral document preparation properties.

```graphql
  key: String
```

### MetadataUpdateInput
Represents metadata.

```graphql
  id: ID!
  name: String
  mimeType: String
  value: String
  content: EntityReferenceInput
```

### LabelInput
Represents a label.

```graphql
  name: String!
  description: String
```

### TextContentInput
Represents text content.

```graphql
  name: String!
  text: String!
```

### MicrosoftContactsCRMFeedPropertiesUpdateInput
Represents Microsoft Contacts CRM feed properties.

```graphql
  authenticationType: MicrosoftContactsAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  tenantId: String
  connector: EntityReferenceInput
```

### ElevenLabsPublishingPropertiesInput
Represents the ElevenLabs Audio publishing properties.

```graphql
  model: ElevenLabsModels
  voice: String
```

### GeometryMetadataInput
Represents geometry metadata.

```graphql
  creationDate: DateTime
  modifiedDate: DateTime
  location: PointInput
  triangleCount: Long
  vertexCount: Long
```

### EntityRelationshipsFilter
Filter for looking up entity relationships.

```graphql
  id: ID!
  limit: Int
  relationshipTypes: [String!]
  includeMetadata: Boolean
  disableInheritance: Boolean
```

### DiscordGuildsInput
Represents Discord guilds properties.

```graphql
  token: String!
```

### DateRangeFilter
Represents a filtered range of date\/time values, in UTC format.

```graphql
  from: DateTime
  to: DateTime
```

### SummarizationStrategyInput
Represents the summarization strategy.

```graphql
  type: SummarizationTypes!
  specification: EntityReferenceInput
  tokens: Int
  items: Int
  prompt: String
```

### LinearFeedPropertiesInput
Represents Linear feed properties.

```graphql
  key: String!
  project: ID!
```

### MedicalProcedureFilter
Represents a filter for medical procedures.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarProcedures: [EntityReferenceFilter!]
  medicalProcedures: [EntityReferenceFilter!]
```

### SlackFeedPropertiesUpdateInput
Represents Slack feed properties.

```graphql
  type: FeedListingTypes
  token: String
  channel: String
  includeAttachments: Boolean
  readLimit: Int
```

### PlaceInput
Represents a place.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  address: AddressInput
  telephone: String
  openingHours: String
  priceRange: String
```

### AzureBlobFeedPropertiesUpdateInput
Represents Azure blob feed properties.

```graphql
  storageAccessKey: String
  accountName: String
  containerName: String
  prefix: String
  listType: BlobListingTypes
```

### GoogleCalendarFeedPropertiesUpdateInput
Represents Google Calendar properties.

```graphql
  type: CalendarListingTypes
  calendarId: String
  beforeDate: DateTime
  afterDate: DateTime
  authenticationType: GoogleCalendarAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### GitHubFeedPropertiesUpdateInput
Represents GitHub properties.

```graphql
  authenticationType: GitHubAuthenticationTypes
  repositoryOwner: String
  repositoryName: String
  uri: URL
  clientId: String
  clientSecret: String
  refreshToken: String
  personalAccessToken: String
  connector: EntityReferenceInput
```

### GoogleEmailFeedPropertiesUpdateInput
Represents Google Email feed properties.

```graphql
  type: EmailListingTypes
  filter: String
  inboxOnly: Boolean
  includeDeletedItems: Boolean
  excludeSentItems: Boolean
  includeSpam: Boolean
  authenticationType: GoogleEmailAuthenticationTypes
  refreshToken: String
  clientId: String
  clientSecret: String
  connector: EntityReferenceInput
```

### PointInput
Represents a geospatial point (i.e. latitude, longitude).

```graphql
  latitude: Float!
  longitude: Float!
  distance: Float
```

### MetadataInput
Represents metadata.

```graphql
  name: String!
  mimeType: String
  value: String
  content: EntityReferenceInput
```

### RevisionStrategyUpdateInput
Represents a revision strategy.

```graphql
  type: RevisionStrategyTypes
  customRevision: String
  count: Int
```

### ObservableInput
Input for an observable entity used in entity resolution.

```graphql
  name: String!
  type: ObservableTypes!
  metadata: String
```

### ContentPublishingConnectorUpdateInput
Represents a content publishing connector.

```graphql
  type: ContentPublishingServiceTypes!
  format: ContentPublishingFormats!
  elevenLabs: ElevenLabsPublishingPropertiesInput
  openAIImage: OpenAIImagePublishingPropertiesInput
  googleImage: GoogleImagePublishingPropertiesInput
  openAIVideo: OpenAIVideoPublishingPropertiesInput
  parallel: ParallelPublishingPropertiesInput
```

### GroqModelPropertiesUpdateInput
Represents Groq model properties.

```graphql
  model: GroqModels
  modelName: String
  key: String
  endpoint: URL
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
```

### PromptStrategyUpdateInput
Represents a prompt strategy.

```graphql
  type: PromptStrategyTypes
```

### PersonFilter
Represents a filter for persons.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  givenName: String
  familyName: String
  phoneNumber: String
  email: String
  uri: URL
  similarPersons: [EntityReferenceFilter!]
  persons: [EntityReferenceFilter!]
```

### RerankingStrategyUpdateInput
Represents a reranking strategy.

```graphql
  serviceType: RerankingModelServiceTypes
  threshold: Float
```

### MetadataFilter
Represents a filter for metadata.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  metadataTypes: [MetadataTypes!]
  content: EntityReferenceFilter
```

### SearchFeedPropertiesUpdateInput
Represents web search feed properties.

```graphql
  type: SearchServiceTypes
  text: String
  readLimit: Int
```

### ConversationFilter
Represents a filter for conversations.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  types: [ConversationTypes!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarConversations: [EntityReferenceFilter!]
  conversations: [EntityReferenceFilter!]
```

### DeepseekModelPropertiesInput
Represents Deepseek model properties.

```graphql
  model: DeepseekModels!
  modelName: String
  key: String
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
```

### CategoryFilter
Represents a filter for categories.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
```

### ResearchFeedPropertiesInput
Represents Research feed properties.

```graphql
  type: FeedServiceTypes
  query: String!
  parallel: ParallelFeedPropertiesInput
  readLimit: Int
```

### EmailIntegrationPropertiesInput
Represents email integration properties.

```graphql
  subject: String!
  from: String!
  to: [String!]!
```

### MedicalProcedureInput
Represents a medical procedure.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### LabelFilter
Represents a filter for labels.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
```

### AmazonFeedPropertiesUpdateInput
Represents Amazon S3 feed properties.

```graphql
  accessKey: String
  secretAccessKey: String
  bucketName: String
  prefix: String
  region: String
```

### MedicalDrugClassUpdateInput
Represents a medical drug class.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### OrganizationInput
Represents an organization.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  address: AddressInput
  foundingDate: DateTime
  email: String
  telephone: String
  legalName: String
  industries: [String]
  revenueCurrency: String
  revenue: Decimal
  investmentCurrency: String
  investment: Decimal
```

### ContentFilterLevel
Represents a filter level for contents.

```graphql
  feeds: [EntityReferenceFilter!]
  workflows: [EntityReferenceFilter!]
  collections: [EntityReferenceFilter!]
  users: [EntityReferenceFilter!]
  observations: [ObservationReferenceFilter!]
```

### IssueMetadataInput
Represents issue metadata.

```graphql
  creationDate: DateTime
  modifiedDate: DateTime
  location: PointInput
  title: String
  project: String
  team: String
  status: String
  priority: String
  type: String
  identifier: String
  labels: [String]
  links: [URL]
```

### DateRangeInput
Range of date\/time values, in UTC format.

```graphql
  from: DateTime
  to: DateTime
```

### GraphStrategyUpdateInput
Represents a GraphRAG strategy.

```graphql
  type: GraphStrategyTypes
  generateGraph: Boolean
  observableLimit: Int
```

### ContentFilter
Represents a filter for contents.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  imageData: String
  imageMimeType: String
  disableInheritance: Boolean
  types: [ContentTypes!]
  fileTypes: [FileTypes!]
  uri: URL
  identifier: String
  location: PointFilter
  h3: H3Filter
  boundaries: [String]
  inLast: TimeSpan
  originalDateRange: DateRangeFilter
  c4id: String
  formats: [String]
  fileExtensions: [String!]
  fileSizeRange: Int64RangeFilter
  similarContents: [EntityReferenceFilter!]
  contents: [EntityReferenceFilter!]
  feeds: [EntityReferenceFilter!]
  workflows: [EntityReferenceFilter!]
  collections: [EntityReferenceFilter!]
  users: [EntityReferenceFilter!]
  observations: [ObservationReferenceFilter!]
  hasFeeds: Boolean
  hasWorkflows: Boolean
  hasCollections: Boolean
  hasObservations: Boolean
  collectionMode: FilterMode
  observationMode: FilterMode
  or: [ContentFilterLevel]
  and: [ContentFilterLevel]
```

### ReplicateModelPropertiesUpdateInput
Represents Replicate model properties.

```graphql
  model: ReplicateModels
  modelName: String
  key: String
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
```

### LinearFeedPropertiesUpdateInput
Represents Linear feed properties.

```graphql
  key: String
  project: ID
```

### BedrockModelPropertiesInput
Represents Amazon Bedrock model properties.

```graphql
  model: BedrockModels!
  modelName: String
  accessKey: String
  secretAccessKey: String
  endpoint: URL
  region: String
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
```

### DropboxFeedPropertiesUpdateInput
Represents Dropbox properties.

```graphql
  authenticationType: DropboxAuthenticationTypes
  path: ID
  appKey: String
  appSecret: String
  refreshToken: String
  redirectUri: String @deprecated(reason: "No longer required. Will be removed in future.")
```

### GraphStrategyInput
Represents a GraphRAG strategy.

```graphql
  type: GraphStrategyTypes
  generateGraph: Boolean
  observableLimit: Int
```

### SlackIntegrationPropertiesInput
Represents Slack integration properties.

```graphql
  channel: String!
  token: String!
```

### GoogleEmailFeedPropertiesInput
Represents Google Email feed properties.

```graphql
  type: EmailListingTypes
  filter: String
  inboxOnly: Boolean
  includeDeletedItems: Boolean
  excludeSentItems: Boolean
  includeSpam: Boolean
  authenticationType: GoogleEmailAuthenticationTypes
  refreshToken: String
  clientId: String
  clientSecret: String
  connector: EntityReferenceInput
```

### WorkflowInput
Represents a workflow.

```graphql
  name: String!
  ingestion: IngestionWorkflowStageInput
  indexing: IndexingWorkflowStageInput
  preparation: PreparationWorkflowStageInput
  extraction: ExtractionWorkflowStageInput
  enrichment: EnrichmentWorkflowStageInput
  classification: ClassificationWorkflowStageInput
  storage: StorageWorkflowStageInput
  actions: [WorkflowActionInput]
```

### IssueFeedPropertiesInput
Represents issue feed properties.

```graphql
  type: FeedServiceTypes!
  includeAttachments: Boolean
  jira: AtlassianJiraFeedPropertiesInput
  linear: LinearFeedPropertiesInput
  github: GitHubIssuesFeedPropertiesInput
  intercom: IntercomTicketsFeedPropertiesInput
  zendesk: ZendeskTicketsFeedPropertiesInput
  trello: TrelloFeedPropertiesInput
  attio: AttioTasksFeedPropertiesInput
  readLimit: Int
```

### TwitterFeedPropertiesInput
Represents Twitter feed properties.

```graphql
  token: String!
  type: TwitterListingTypes
  userName: String
  query: String
  includeAttachments: Boolean
  readLimit: Int
```

### GoogleCalendarFeedPropertiesInput
Represents Google Calendar properties.

```graphql
  type: CalendarListingTypes
  calendarId: String
  beforeDate: DateTime
  afterDate: DateTime
  authenticationType: GoogleCalendarAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### ViewFilter
Represents a filter for views.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  types: [ViewTypes]
```

### EventInput
Represents an event.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  address: AddressInput
  startDate: DateTime
  endDate: DateTime
  availabilityStartDate: DateTime
  availabilityEndDate: DateTime
  price: Decimal
  minPrice: Decimal
  maxPrice: Decimal
  priceCurrency: String
  isAccessibleForFree: Boolean
  typicalAgeRange: String
  organizer: String
  performer: String
  sponsor: String
  eventStatus: String
```

### GoogleImagePublishingPropertiesInput
Represents the Google Image publishing properties.

```graphql
  model: GoogleImageModels
  count: Int
  seed: EntityReferenceInput
```

### IntegrationConnectorInput
Represents an integration connector.

```graphql
  type: IntegrationServiceTypes!
  uri: String
  slack: SlackIntegrationPropertiesInput
  email: EmailIntegrationPropertiesInput
  twitter: TwitterIntegrationPropertiesInput
  mcp: MCPIntegrationPropertiesInput
```

### MedicalGuidelineFacetInput
Represents the configuration for medical guideline facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: MedicalGuidelineFacetTypes
```

### CommitFeedPropertiesUpdateInput
Represents commit feed properties.

```graphql
  github: GitHubCommitsFeedPropertiesUpdateInput
  readLimit: Int
```

### RepoInput
Represents a code repository.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### SearchFeedPropertiesInput
Represents web search feed properties.

```graphql
  type: SearchServiceTypes
  text: String!
  readLimit: Int
```

### ContentClassificationConnectorInput
Represents a content classification connector.

```graphql
  type: ContentClassificationServiceTypes
  contentType: ContentTypes
  fileType: FileTypes
  model: ModelContentClassificationPropertiesInput
  regex: RegexContentClassificationPropertiesInput
```

### RerankingStrategyInput
Represents a reranking strategy.

```graphql
  serviceType: RerankingModelServiceTypes!
  threshold: Float
```

### MedicalDeviceUpdateInput
Represents a medical device.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### AudioMetadataInput
Represents audio metadata.

```graphql
  creationDate: DateTime
  modifiedDate: DateTime
  location: PointInput
  keywords: [String]
  author: String
  series: String
  episode: String
  episodeType: String
  season: String
  publisher: String
  copyright: String
  genre: String
  title: String
  bitrate: Int
  channels: Int
  sampleRate: Int
  bitsPerSample: Int
  duration: String
```

### AzureDocumentPreparationPropertiesInput
Represents the Azure Document Intelligence preparation properties.

```graphql
  model: AzureDocumentIntelligenceModels
  endpoint: URL
  key: String
  version: AzureDocumentIntelligenceVersions
```

### FHIREnrichmentPropertiesInput
Represents an FHIR entity enrichment connector.

```graphql
  endpoint: URL
```

### EventFacetInput
Represents the configuration for event facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: EventFacetTypes
```

### EventMetadataInput
Represents event metadata.

```graphql
  creationDate: DateTime
  modifiedDate: DateTime
  location: PointInput
  subject: String
  eventId: String
  calendarId: String
  startDateTime: DateTime
  endDateTime: DateTime
  isAllDay: Boolean
  timezone: String
  status: CalendarEventStatus
  visibility: CalendarEventVisibility
  meetingLink: String
  organizer: CalendarAttendeeInput
  attendees: [CalendarAttendeeInput]
  categories: [String]
  reminders: [CalendarReminderInput]
  recurrence: CalendarRecurrenceInput
  recurringEventId: String
  isRecurring: Boolean
  links: [LinkReferenceInput]
```

### FilePreparationConnectorInput
Represents a file preparation connector.

```graphql
  type: FilePreparationServiceTypes!
  fileTypes: [FileTypes!]
  page: PagePreparationPropertiesInput
  document: DocumentPreparationPropertiesInput
  email: EmailPreparationPropertiesInput
  azureDocument: AzureDocumentPreparationPropertiesInput
  deepgram: DeepgramAudioPreparationPropertiesInput
  assemblyAI: AssemblyAIAudioPreparationPropertiesInput
  mistral: MistralDocumentPreparationPropertiesInput
  modelDocument: ModelDocumentPreparationPropertiesInput
  reducto: ReductoDocumentPreparationPropertiesInput
```

### ContentInput
Represents content.

```graphql
  name: String!
  type: ContentTypes
  uri: URL
  description: String
  text: String
  identifier: String
  fileCreationDate: DateTime
  fileModifiedDate: DateTime
  creationDate: DateTime
  modifiedDate: DateTime
  workflow: EntityReferenceInput
```

### MedicalIndicationFacetInput
Represents the configuration for medical indication facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: MedicalIndicationFacetTypes
```

### MedicalTestFacetInput
Represents the configuration for medical test facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: MedicalTestFacetTypes
```

### DiffbotEnrichmentPropertiesInput
Represents an Diffbot entity enrichment connector.

```graphql
  key: String
```

### ContentGraphInput
Represents the configuration for retrieving the knowledge graph.

```graphql
  types: [ObservableTypes!]
```

### GraphFilter
Filter for querying entity knowledge graphs.

```graphql
  types: [ObservableTypes!]
  feeds: [EntityReferenceFilter!]
  creationDateRange: DateRangeFilter
  createdInLast: TimeSpan
  location: PointFilter
  h3: H3Filter
  boundaries: [String]
  search: String
  searchType: SearchTypes
  offset: Int
  limit: Int
  disableInheritance: Boolean
```

### AddressFilter
Represents a filter for addresses.

```graphql
  streetAddress: String
  city: String
  region: String
  country: String
  postalCode: String
```

### CRMFeedPropertiesInput
Represents entity feed properties.

```graphql
  type: FeedServiceTypes!
  attio: AttioCRMFeedPropertiesInput
  googleContacts: GoogleContactsCRMFeedPropertiesInput
  microsoftContacts: MicrosoftContactsCRMFeedPropertiesInput
  readLimit: Int
```

### MedicalIndicationInput
Represents a medical indication.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### SoftwareFacetInput
Represents the configuration for software facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: SoftwareFacetTypes
```

### GitHubIssuesFeedPropertiesInput
Represents GitHub Issues feed properties.

```graphql
  authenticationType: GitHubIssueAuthenticationTypes
  repositoryOwner: String!
  repositoryName: String!
  uri: URL
  clientId: String
  clientSecret: String
  refreshToken: String
  personalAccessToken: String
  connector: EntityReferenceInput
```

### AlertInput
Represents an alert.

```graphql
  name: String!
  type: AlertTypes!
  summaryPrompt: String
  publishPrompt: String!
  view: EntityReferenceInput
  filter: ContentCriteriaInput
  publishing: ContentPublishingConnectorInput!
  integration: IntegrationConnectorInput!
  summarySpecification: EntityReferenceInput
  publishSpecification: EntityReferenceInput
  schedulePolicy: AlertSchedulePolicyInput
```

### DocumentMetadataInput
Represents document metadata.

```graphql
  creationDate: DateTime
  modifiedDate: DateTime
  location: PointInput
  title: String
  subject: String
  author: String
  software: String
  publisher: String
  description: String
  summary: String
  comments: String
  identifier: String
  keywords: [String]
  links: [URL]
  pageCount: Int
  worksheetCount: Int
  slideCount: Int
  wordCount: Int
  lineCount: Int
  paragraphCount: Int
  characterCount: Int
  totalEditingTime: String
  isEncrypted: Boolean
  hasDigitalSignature: Boolean
```

### NotionFeedPropertiesInput
Represents Notion feed properties.

```graphql
  isRecursive: Boolean
  token: String!
  type: NotionTypes!
  identifiers: [String!]!
  readLimit: Int
```

### AuthenticationConnectorInput
Represents an authentication connector.

```graphql
  type: AuthenticationServiceTypes!
  microsoft: MicrosoftAuthenticationPropertiesInput
  google: GoogleAuthenticationPropertiesInput
  arcade: ArcadeAuthenticationPropertiesInput
  oauth: OAuthAuthenticationPropertiesInput
```

### YouTubeFeedPropertiesInput
Represents YouTube feed properties.

```graphql
  type: YouTubeTypes!
  videoName: String
  videoIdentifiers: [String!]
  channelIdentifier: String
  playlistIdentifier: String
  readLimit: Int
```

### MedicalProcedureFacetInput
Represents the configuration for medical procedure facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: MedicalProcedureFacetTypes
```

### XAIModelPropertiesInput
Represents xAI model properties.

```graphql
  model: XAIModels!
  modelName: String
  key: String
  endpoint: URL
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
```

### MedicalConditionInput
Represents a medical condition.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### EmbeddingsStrategyInput
Represents the embeddings strategy.

```graphql
  textSpecification: EntityReferenceInput
  imageSpecification: EntityReferenceInput
```

### AlertSchedulePolicyInput
Represents an alert scheduling policy.

```graphql
  recurrenceType: TimedPolicyRecurrenceTypes
  repeatInterval: TimeSpan
  cron: String
  timeZoneId: String
```

### MedicalGuidelineUpdateInput
Represents a medical guideline.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### MessageMetadataInput
Represents message metadata.

```graphql
  creationDate: DateTime
  modifiedDate: DateTime
  location: PointInput
  identifier: String
  conversationIdentifier: String
  channelIdentifier: String
  channelName: String
  attachmentCount: Int
  links: [LinkReferenceInput]
  author: PersonReferenceInput
  mentions: [PersonReferenceInput]
```

### EventUpdateInput
Represents an event.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  address: AddressInput
  startDate: DateTime
  endDate: DateTime
  availabilityStartDate: DateTime
  availabilityEndDate: DateTime
  price: Decimal
  minPrice: Decimal
  maxPrice: Decimal
  priceCurrency: String
  isAccessibleForFree: Boolean
  typicalAgeRange: String
  organizer: String
  performer: String
  sponsor: String
  eventStatus: String
```

### LinkReferenceInput
Represents a hyperlink.

```graphql
  uri: URL
  linkType: LinkTypes
  excerpts: String
```

### GoogleDriveFeedPropertiesUpdateInput
Represents Google Drive properties.

```graphql
  authenticationType: GoogleDriveAuthenticationTypes
  files: [String]
  folderId: String
  refreshToken: String
  clientId: String
  clientSecret: String
  serviceAccountJson: String
  connector: EntityReferenceInput
```

### CohereModelPropertiesUpdateInput
Represents Cohere model properties.

```graphql
  model: CohereModels
  modelName: String
  key: String
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
  chunkTokenLimit: Int
```

### MedicalGuidelineInput
Represents a medical guideline.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### RepoFilter
Represents a filter for code repositories.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarRepos: [EntityReferenceFilter!]
  repos: [EntityReferenceFilter!]
```

### MedicalDrugFilter
Represents a filter for medical drugs.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarDrugs: [EntityReferenceFilter!]
  medicalDrugs: [EntityReferenceFilter!]
```

### MedicalDrugClassFacetInput
Represents the configuration for medical drug class facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: MedicalDrugClassFacetTypes
```

### GoogleModelPropertiesUpdateInput
Represents Google model properties.

```graphql
  model: GoogleModels
  modelName: String
  key: String
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
  chunkTokenLimit: Int
  enableThinking: Boolean
  thinkingTokenLimit: Int
```

### ContentIndexingConnectorInput
Represents a content indexing connector.

```graphql
  type: ContentIndexingServiceTypes
  contentType: ContentTypes
  fileType: FileTypes
```

### SlackFeedPropertiesInput
Represents Slack feed properties.

```graphql
  type: FeedListingTypes
  token: String!
  channel: String!
  includeAttachments: Boolean
  readLimit: Int
```

### RetrievalStrategyInput
Represents a retrieval strategy.

```graphql
  type: RetrievalStrategyTypes!
  contentLimit: Int
  disableFallback: Boolean
```

### SpecificationFilter
Represents a filter for LLM specifications.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  types: [SpecificationTypes!]
  serviceTypes: [ModelServiceTypes!]
```

### DropboxFoldersInput
Represents Dropbox folders properties.

```graphql
  authenticationType: DropboxAuthenticationTypes
  appKey: String
  appSecret: String
  refreshToken: String
```

### CalendarFeedPropertiesInput
Represents calendar feed properties.

```graphql
  type: FeedServiceTypes!
  includeAttachments: Boolean
  enableMeetingRecording: Boolean
  meetingBotName: String
  google: GoogleCalendarFeedPropertiesInput
  microsoft: MicrosoftCalendarFeedPropertiesInput
  readLimit: Int
```

### RetrievalStrategyUpdateInput
Represents a retrieval strategy.

```graphql
  type: RetrievalStrategyTypes
  contentLimit: Int
```

### ObservationOccurrenceInput
Represents an observation occurrence.

```graphql
  type: OccurrenceTypes!
  confidence: Float
  boundingBox: BoundingBoxInput
  pageIndex: Int
  startTime: TimeSpan
  endTime: TimeSpan
```

### EntityFeedPropertiesInput
Represents entity discovery feed properties.

```graphql
  type: FeedServiceTypes!
  query: String!
  parallel: ParallelEntityFeedPropertiesInput
  readLimit: Int
```

### MCPIntegrationPropertiesInput
Represents MCP integration properties.

```graphql
  type: MCPServerTypes!
  token: String
```

### IndexingWorkflowStageInput
Represents the indexing workflow stage.

```graphql
  jobs: [IndexingWorkflowJobInput]
```

### PagePreparationPropertiesInput
Represents the web page preparation properties.

```graphql
  enableScreenshot: Boolean
```

### ZendeskFeedPropertiesUpdateInput
Represents Zendesk feed properties.

```graphql
  subdomain: String
  accessToken: String
  readLimit: Int
```

### SoftwareInput
Represents software.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  developer: String
  releaseDate: DateTime
```

### CollectionFilter
Represents a filter for collections.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  types: [CollectionTypes!]
  disableInheritance: Boolean
```

### AmazonFeedPropertiesInput
Represents Amazon S3 feed properties.

```graphql
  accessKey: String!
  secretAccessKey: String!
  bucketName: String!
  prefix: String
  region: String
```

### EventFilter
Represents a filter for events.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  startDateRange: DateRangeFilter
  endDateRange: DateRangeFilter
  availabilityStartDateRange: DateRangeFilter
  availabilityEndDateRange: DateRangeFilter
  price: Decimal
  minPrice: Decimal
  maxPrice: Decimal
  priceCurrency: String
  isAccessibleForFree: Boolean
  typicalAgeRange: String
  similarEvents: [EntityReferenceFilter!]
  events: [EntityReferenceFilter!]
```

### MedicalContraindicationInput
Represents a medical contraindication.

```graphql
  name: String!
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
```

### DiscordFeedPropertiesInput
Represents Discord feed properties.

```graphql
  type: FeedListingTypes
  token: String!
  channel: String!
  includeAttachments: Boolean
  readLimit: Int
```

### AzureAIModelPropertiesInput
Represents Azure AI model properties.

```graphql
  key: String!
  endpoint: URL!
  temperature: Float
  probability: Float
  tokenLimit: Int!
  completionTokenLimit: Int
  chunkTokenLimit: Int
```

### EntityExtractionConnectorInput
Represents an entity extraction connector.

```graphql
  type: EntityExtractionServiceTypes!
  contentTypes: [ContentTypes!]
  fileTypes: [FileTypes!]
  extractedTypes: [ObservableTypes!]
  extractedCount: Int
  azureText: AzureTextExtractionPropertiesInput
  azureImage: AzureImageExtractionPropertiesInput
  modelText: ModelTextExtractionPropertiesInput
  modelImage: ModelImageExtractionPropertiesInput
```

### MicrosoftCalendarFeedPropertiesInput
Represents Microsoft Calendar properties.

```graphql
  type: CalendarListingTypes
  calendarId: String
  beforeDate: DateTime
  afterDate: DateTime
  authenticationType: MicrosoftCalendarAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### PlaceFilter
Represents a filter for places.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  similarPlaces: [EntityReferenceFilter!]
  places: [EntityReferenceFilter!]
```

### MistralModelPropertiesUpdateInput
Represents Mistral model properties.

```graphql
  model: MistralModels
  modelName: String
  key: String
  endpoint: URL
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
  chunkTokenLimit: Int
```

### PullRequestFeedPropertiesInput
Represents pull request feed properties.

```graphql
  type: FeedServiceTypes!
  github: GitHubPullRequestsFeedPropertiesInput
  readLimit: Int
```

### AttioTasksFeedPropertiesInput
Represents Attio Tasks feed properties.

```graphql
  apiKey: String!
```

### TrelloFeedPropertiesUpdateInput
Represents Trello feed properties.

```graphql
  key: String
  token: String
  type: TrelloTypes
  identifiers: [String!]
```

### WebFeedPropertiesInput
Represents web feed properties.

```graphql
  uri: URL!
  allowedPaths: [String!]
  excludedPaths: [String!]
  includeFiles: Boolean
  readLimit: Int
```

### AzureFileFeedPropertiesInput
Represents Azure file share feed properties.

```graphql
  storageAccessKey: String!
  accountName: String!
  shareName: String!
  prefix: String
```

### IndexingWorkflowJobInput
Represents a indexing workflow job.

```graphql
  connector: ContentIndexingConnectorInput
```

### RedditFeedPropertiesInput
Represents Reddit feed properties.

```graphql
  subredditName: String!
  readLimit: Int
```

### SlackChannelsInput
Represents Slack channels properties.

```graphql
  token: String!
```

### OrganizationFacetInput
Represents the configuration for organization facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: OrganizationFacetTypes
```

### CerebrasModelPropertiesInput
Represents Cerebras model properties.

```graphql
  model: CerebrasModels!
  modelName: String
  key: String
  endpoint: URL
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
```

### EnrichmentWorkflowJobInput
Represents an enrichment workflow job.

```graphql
  connector: EntityEnrichmentConnectorInput
```

### DropboxFeedPropertiesInput
Represents Dropbox properties.

```graphql
  authenticationType: DropboxAuthenticationTypes
  path: ID
  appKey: String
  appSecret: String
  refreshToken: String
  redirectUri: String @deprecated(reason: "No longer required. Will be removed in future.")
```

### CalendarReminderInput
Represents a calendar event reminder input.

```graphql
  minutesBefore: Int
  method: CalendarReminderMethod
```

### MedicalStudyUpdateInput
Represents a medical study.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  address: AddressInput
```

### GoogleDriveFoldersInput
Represents Google Drive folders properties.

```graphql
  authenticationType: GoogleDriveAuthenticationTypes
  clientId: String
  clientSecret: String
  refreshToken: String
  connector: EntityReferenceInput
```

### FeedSchedulePolicyInput
Represents a feed schedule policy.

```graphql
  recurrenceType: TimedPolicyRecurrenceTypes!
  repeatInterval: TimeSpan
```

### InvestmentUpdateInput
Represents an investment.

```graphql
  id: ID!
  name: String
  uri: URL
  identifier: String
  description: String
  location: PointInput
  boundary: String
  amountCurrency: String
  amount: Decimal
  status: String
  stage: String
  investmentDate: DateTime
  roundSize: Decimal
  roundSizeCurrency: String
  postValuation: Decimal
  postValuationCurrency: String
  sharesOwned: Decimal
  vehicle: String
  entryPricePerShare: Decimal
  currentPricePerShare: Decimal
  discountPercent: Decimal
  proRataRights: Boolean
  investor: EntityReferenceInput
  organization: EntityReferenceInput
```

### OrganizationFilter
Represents a filter for organizations.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  disableInheritance: Boolean
  feeds: [EntityReferenceFilter!]
  feedMode: FilterMode
  address: AddressFilter
  location: PointFilter
  h3: H3Filter
  boundaries: [String!]
  searchType: SearchTypes
  queryType: SearchQueryTypes
  numberSimilar: Int
  uri: URL
  similarOrganizations: [EntityReferenceFilter!]
  organizations: [EntityReferenceFilter!]
```

### ContentUpdateInput
Represents content.

```graphql
  id: ID!
  name: String
  description: String
  identifier: String
  fileCreationDate: DateTime
  fileModifiedDate: DateTime
  creationDate: DateTime
  modifiedDate: DateTime
  summary: String
  customSummary: String
  keywords: [String!]
  bullets: [String!]
  headlines: [String!]
  posts: [String!]
  chapters: [String!]
  questions: [String!]
  quotes: [String!]
  video: VideoMetadataInput
  audio: AudioMetadataInput
  image: ImageMetadataInput
  document: DocumentMetadataInput
  email: EmailMetadataInput
  event: EventMetadataInput
  issue: IssueMetadataInput
  message: MessageMetadataInput
  post: PostMetadataInput
  drawing: DrawingMetadataInput
  shape: ShapeMetadataInput
  geometry: GeometryMetadataInput
  pointCloud: PointCloudMetadataInput
  package: PackageMetadataInput
  language: LanguageMetadataInput
```

### CategoryInput
Represents a category.

```graphql
  name: String!
  description: String
```

### ProductFacetInput
Represents the configuration for product facets.

```graphql
  timeInterval: TimeIntervalTypes
  timeOffset: Int
  facet: ProductFacetTypes
```

### ConversationInput
Represents a conversation.

```graphql
  name: String!
  type: ConversationTypes
  messages: [ConversationMessageInput!]
  tools: [ToolDefinitionInput!]
  specification: EntityReferenceInput
  fallbacks: [EntityReferenceInput]
  filter: ContentCriteriaInput
  augmentedFilter: ContentCriteriaInput
```

### EntityReferenceFilter
Represents an entity reference filter.

```graphql
  id: ID!
```

### WorkflowUpdateInput
Represents a workflow.

```graphql
  id: ID!
  name: String
  ingestion: IngestionWorkflowStageInput
  indexing: IndexingWorkflowStageInput
  preparation: PreparationWorkflowStageInput
  extraction: ExtractionWorkflowStageInput
  enrichment: EnrichmentWorkflowStageInput
  classification: ClassificationWorkflowStageInput
  storage: StorageWorkflowStageInput
  actions: [WorkflowActionInput]
```

### AzureOpenAIModelPropertiesInput
Represents Azure OpenAI model properties.

```graphql
  model: AzureOpenAIModels!
  deploymentName: String
  key: String
  endpoint: URL
  temperature: Float
  probability: Float
  tokenLimit: Int
  completionTokenLimit: Int
  chunkTokenLimit: Int
```

### ProjectUpdateInput
Represents a project.

```graphql
  workflow: EntityReferenceInput
  specification: EntityReferenceInput
  embeddings: EmbeddingsStrategyInput
  callbackUri: URL
```

### SpecificationUpdateInput
Represents an LLM specification.

```graphql
  id: ID!
  name: String
  type: SpecificationTypes
  serviceType: ModelServiceTypes!
  searchType: ConversationSearchTypes
  numberSimilar: Int
  systemPrompt: String
  customGuidance: String
  customInstructions: String
  strategy: ConversationStrategyUpdateInput
  promptStrategy: PromptStrategyUpdateInput
  retrievalStrategy: RetrievalStrategyUpdateInput
  rerankingStrategy: RerankingStrategyUpdateInput
  graphStrategy: GraphStrategyUpdateInput
  revisionStrategy: RevisionStrategyUpdateInput
  azureAI: AzureAIModelPropertiesUpdateInput
  openAI: OpenAIModelPropertiesUpdateInput
  azureOpenAI: AzureOpenAIModelPropertiesUpdateInput
  cohere: CohereModelPropertiesUpdateInput
  anthropic: AnthropicModelPropertiesUpdateInput
  google: GoogleModelPropertiesUpdateInput
  replicate: ReplicateModelPropertiesUpdateInput
  mistral: MistralModelPropertiesUpdateInput
  bedrock: BedrockModelPropertiesUpdateInput
  xai: XAIModelPropertiesUpdateInput
  groq: GroqModelPropertiesUpdateInput
  cerebras: CerebrasModelPropertiesUpdateInput
  deepseek: DeepseekModelPropertiesUpdateInput
  jina: JinaModelPropertiesUpdateInput
  voyage: VoyageModelPropertiesUpdateInput
```

### IntercomTicketsFeedPropertiesUpdateInput
Represents Intercom Tickets feed properties.

```graphql
  accessToken: String
```

### ClassificationWorkflowJobInput
Represents a classification workflow job.

```graphql
  connector: ContentClassificationConnectorInput
```

### IssueFeedPropertiesUpdateInput
Represents issue feed properties.

```graphql
  includeAttachments: Boolean
  jira: AtlassianJiraFeedPropertiesUpdateInput
  linear: LinearFeedPropertiesUpdateInput
  github: GitHubIssuesFeedPropertiesUpdateInput
  intercom: IntercomTicketsFeedPropertiesUpdateInput
  zendesk: ZendeskTicketsFeedPropertiesUpdateInput
  trello: TrelloFeedPropertiesUpdateInput
  attio: AttioTasksFeedPropertiesUpdateInput
  readLimit: Int
```

### ConversationStrategyUpdateInput
Represents a conversation strategy.

```graphql
  type: ConversationStrategyTypes
  messageLimit: Int
  embedCitations: Boolean
  flattenCitations: Boolean
  enableFacets: Boolean
  messagesWeight: Float
  contentsWeight: Float
```

### ObservationUpdateInput
Represents an observation.

```graphql
  id: ID!
  type: ObservableTypes
  observable: NamedEntityReferenceInput
  related: NamedEntityReferenceInput
  relatedType: ObservableTypes
  relation: String
  occurrences: [ObservationOccurrenceInput!]
```

### FeedFilter
Represents a filter for feeds.

```graphql
  search: String
  orderBy: OrderByTypes
  direction: OrderDirectionTypes
  offset: Int
  limit: Int
  relevanceThreshold: Float
  id: ID
  name: String
  states: [EntityState!]
  createdInLast: TimeSpan
  creationDateRange: DateRangeFilter
  modifiedInLast: TimeSpan
  modifiedDateRange: DateRangeFilter
  types: [FeedTypes!]
```

### LabelUpdateInput
Represents a label.

```graphql
  id: ID!
  name: String
  description: String
```

### AttioFeedPropertiesInput
Represents Attio feed properties.

```graphql
  apiKey: String!
  readLimit: Int
```

## Enums

### OrderByTypes
`NAME, CREATION_DATE, ORIGINAL_DATE, RELEVANCE`

### ContentTypes
`FILE, PAGE, MESSAGE, TEXT, POST, EMAIL, EVENT, ISSUE, PULL_REQUEST, COMMIT, MEMORY`

### CollectionTypes
`COLLECTION, THREAD, SERIES, FOLDER`

### BedrockModels
`LLAMA_4_MAVERICK_17B, LLAMA_4_SCOUT_17B, CLAUDE_3_7_SONNET, NOVA_PREMIER, NOVA_PRO, CUSTOM`

### EntityExtractionServiceTypes
`MODEL_TEXT, MODEL_IMAGE, OPEN_AI_IMAGE @deprecated(reason: "Use MODEL_IMAGE instead."), AZURE_COGNITIVE_SERVICES_IMAGE, AZURE_COGNITIVE_SERVICES_TEXT`

### ModelServiceTypes
`GOOGLE, ANTHROPIC, AZURE_AI, AZURE_OPEN_AI, OPEN_AI, REPLICATE, GROQ, CEREBRAS, MISTRAL, COHERE, DEEPSEEK, JINA, VOYAGE, BEDROCK, XAI`

### FilterMode
`ANY, ONLY, ALL`

### RenditionTypes
`CONTENT`

### FilePreparationServiceTypes
`AZURE_DOCUMENT_INTELLIGENCE, DEEPGRAM, DOCUMENT, EMAIL, PAGE, REDUCTO_DOCUMENT, MODEL_DOCUMENT, ASSEMBLY_AI, MISTRAL_DOCUMENT`

### MedicalDeviceFacetTypes
`CREATION_DATE`

### ContentSourceTypes
`FRAME, DOCUMENT, TRANSCRIPT`

### OperationTypes
`QUERY, MUTATION`

### EmailListingTypes
`PAST, NEW`

### SoftwareFacetTypes
`CREATION_DATE`

### ParallelGenerators
`BASE, CORE, PRO`

### BoxAuthenticationTypes
`USER`

### MedicalStudyFacetTypes
`CREATION_DATE`

### ConnectorTypes
`INTEGRATION, AUTHENTICATION, SITE`

### MedicalIndicationFacetTypes
`CREATION_DATE`

### EmbeddingTypes
`TEXT, IMAGE, AUDIO, VIDEO`

### CalendarReminderMethod
`EMAIL, POPUP, SMS`

### PlaceFacetTypes
`CREATION_DATE`

### GoogleContactsAuthenticationTypes
`USER, CONNECTOR`

### ContentPublishingFormats
`PNG, JPEG, WEBP, MP3, MP4, TEXT, MARKDOWN, HTML`

### MailImportance
`NORMAL, LOW, HIGH`

### TimeIntervalTypes
`MINUTE, HOUR, DAY, WEEK, MONTH, QUARTER, YEAR`

### DeepseekModels
`REASONER, CHAT, CODER @deprecated(reason: "Deepseek Coder has been merged with Deepseek Chat, as of v2.5. Use Deepseek Chat instead."), CUSTOM`

### MedicalDrugClassFacetTypes
`CREATION_DATE`

### ParallelProcessors
`BASE, CORE, PRO, ULTRA, ULTRA2X, ULTRA4X, ULTRA8X`

### FileTypes
`VIDEO, AUDIO, IMAGE, ANIMATION, DOCUMENT, EMAIL @deprecated(reason: "Email files now use ContentTypes.Email instead. FileTypes.Email is maintained for backward compatibility with existing data only."), CODE, DATA, PACKAGE, SHAPE, POINT_CLOUD, GEOMETRY, DRAWING, MANIFEST, UNKNOWN`

### ApplyPolicy
`BEFORE_RESOLVER, AFTER_RESOLVER, VALIDATION`

### ContentIndexingServiceTypes
`AZURE_AI_LANGUAGE`

### RevisionStrategyTypes
`REVISE, CUSTOM, NONE`

### RerankingModelServiceTypes
`COHERE, JINA, VOYAGE`

### SummarizationTypes
`SUMMARY, KEYWORDS, BULLETS, HEADLINES, POSTS, CHAPTERS, QUESTIONS, QUOTES, GEOTAG, CUSTOM`

### ContentFacetTypes
`CREATION_DATE, ORIGINAL_DATE, OBSERVABLE, CONTENT_TYPE, FILE_TYPE, FORMAT, FORMAT_NAME, FILE_EXTENSION, FILE_SIZE, DEVICE_TYPE, IMAGE_MAKE, IMAGE_MODEL, IMAGE_SOFTWARE, AUDIO_AUTHOR, AUDIO_SERIES, AUDIO_PUBLISHER, VIDEO_MAKE, VIDEO_MODEL, VIDEO_SOFTWARE, DOCUMENT_AUTHOR, DOCUMENT_PUBLISHER, DOCUMENT_IS_ENCRYPTED, DOCUMENT_HAS_DIGITAL_SIGNATURE, EMAIL_PRIORITY, EMAIL_SENSITIVITY, ISSUE_PROJECT, ISSUE_TEAM, ISSUE_PRIORITY, ISSUE_STATUS, ISSUE_TYPE`

### ConversationStrategyTypes
`WINDOWED, SUMMARIZED`

### ElevenLabsModels
`MULTILINGUAL_V1, MULTILINGUAL_V2, ENGLISH_V1, FLASH_V2, FLASH_V2_5, TURBO_V2 @deprecated(reason: "Use Flash_V2 instead."), TURBO_V2_5 @deprecated(reason: "Use Flash_V2_5 instead.")`

### CalendarAttendeeResponseStatus
`NEEDS_ACTION, DECLINED, TENTATIVE, ACCEPTED`

### LinkTypes
`DROPBOX, TYPE_FORM, AIRTABLE, MICROSOFT_TEAMS, DISCORD, APPLE, SLACK, ANGEL_LIST, CRUNCHBASE, LINKED_IN, DIFFBOT, REDDIT, GOOGLE, IFTTT, FACEBOOK, WIKIPEDIA, WIKIMEDIA, WIKIDATA, INSTAGRAM, TWITCH, POCKET_CASTS, SPOTIFY, TUNE_IN, STITCHER, ANCHOR_FM, TRANSISTOR_FM, I_TUNES, PANDORA, SOUND_CLOUD, BANDCAMP, TIK_TOK, YOU_TUBE, TWITTER, X, MEDIUM, NOTION, LINEAR, GIT_HUB, GIT_HUB_PAGES, RSS, EMAIL, MEDIA, WEB, FILE`

### GitHubCommitAuthenticationTypes
`PERSONAL_ACCESS_TOKEN, O_AUTH, CONNECTOR`

### ViewTypes
`CONTENT`

### PersonFacetTypes
`CREATION_DATE`

### OneDriveAuthenticationTypes
`USER, CONNECTOR`

### YouTubeTypes
`VIDEO, VIDEOS, PLAYLIST, CHANNEL`

### ObservableTypes
`CATEGORY, LABEL, EVENT, INVESTMENT, INVESTMENT_FUND, ORGANIZATION, PERSON, PLACE, PRODUCT, REPO, SOFTWARE, MEDICAL_STUDY, MEDICAL_CONDITION, MEDICAL_GUIDELINE, MEDICAL_DRUG, MEDICAL_DRUG_CLASS, MEDICAL_INDICATION, MEDICAL_CONTRAINDICATION, MEDICAL_TEST, MEDICAL_DEVICE, MEDICAL_THERAPY, MEDICAL_PROCEDURE`

### MedicalGuidelineFacetTypes
`CREATION_DATE`

### ArcadeProviders
`GOOGLE, GIT_HUB, MICROSOFT`

### CalendarEventStatus
`CONFIRMED, TENTATIVE, CANCELLED`

### CalendarListingTypes
`PAST, NEW`

### OccurrenceTypes
`IMAGE, TIME, TEXT`

### AzureOpenAIModels
`GPT35_TURBO_16K @deprecated(reason: "Built-in Azure OpenAI models are longer supported. Use a developer-specified deployment instead."), GPT4 @deprecated(reason: "Built-in Azure OpenAI models are longer supported. Use a developer-specified deployment instead."), GPT4_TURBO_128K @deprecated(reason: "Built-in Azure OpenAI models are longer supported. Use a developer-specified deployment instead."), CUSTOM`

### BillableMetrics
`BYTES, TOKENS, LENGTH, TIME, UNITS, COST, REQUESTS, CREDITS`

### CategoryFacetTypes
`CREATION_DATE`

### MicrosoftContactsAuthenticationTypes
`USER, CONNECTOR`

### ResourceConnectorTypes
`AMAZON, AZURE, GOOGLE`

### OpenAIVisionDetailLevels
`HIGH, LOW`

### AnthropicModels
`CLAUDE_2 @deprecated(reason: "Use Claude 4.x instead."), CLAUDE_2_0 @deprecated(reason: "Use Claude 4.x instead."), CLAUDE_2_1 @deprecated(reason: "Use Claude 4.x instead."), CLAUDE_INSTANT_1 @deprecated(reason: "Use Claude 3.5 Haiku instead."), CLAUDE_INSTANT_1_2 @deprecated(reason: "Use Claude 3.5 Haiku instead."), CLAUDE_3_OPUS @deprecated(reason: "Use Claude 4 Opus instead."), CLAUDE_3_OPUS_20240229, CLAUDE_3_SONNET @deprecated(reason: "Use Claude 4 Sonnet instead."), CLAUDE_3_SONNET_20240229 @deprecated(reason: "Use Claude 4 Sonnet instead."), CLAUDE_3_HAIKU, CLAUDE_3_HAIKU_20240307, CLAUDE_3_5_SONNET @deprecated(reason: "Use Claude 4.5 Sonnet instead."), CLAUDE_3_5_SONNET_20241022 @deprecated(reason: "Use Claude 4.5 Sonnet instead."), CLAUDE_3_5_SONNET_20240620 @deprecated(reason: "Use Claude 4.5 Sonnet instead."), CLAUDE_3_5_HAIKU, CLAUDE_3_5_HAIKU_20241022, CLAUDE_3_7_SONNET, CLAUDE_3_7_SONNET_20250219, CLAUDE_4_SONNET, CLAUDE_4_SONNET_20250514, CLAUDE_4_5_SONNET, CLAUDE_4_5_SONNET_20250929, CLAUDE_4_5_OPUS, CLAUDE_4_5_OPUS_20251101, CLAUDE_4_OPUS, CLAUDE_4_OPUS_20250514, CLAUDE_4_1_OPUS, CLAUDE_4_1_OPUS_20250805, CLAUDE_4_5_HAIKU, CLAUDE_4_5_HAIKU_20251001, CUSTOM`

### GoogleDriveAuthenticationTypes
`SERVICE_ACCOUNT, USER, CONNECTOR`

### SearchQueryTypes
`SIMPLE, FULL`

### FeedListingTypes
`PAST, NEW`

### OrientationTypes
`TOP_LEFT, TOP_RIGHT, BOTTOM_RIGHT, BOTTOM_LEFT, LEFT_TOP, RIGHT_TOP, RIGHT_BOTTOM, LEFT_BOTTOM`

### ImageProjectionTypes
`EQUIRECTANGULAR, CYLINDRICAL`

### MedicalTestFacetTypes
`CREATION_DATE`

### AlertTypes
`PROMPT`

### UnitTypes
`KILOMETER, METER, CENTIMETER, MILLIMETER, MICROMETER, NANOMETER, ANGSTROM, DECIMETER, DECAMETER, HECTOMETER, GIGAMETER, ASTRONOMICAL_UNIT, LIGHT_YEAR, PARSEC, MILE, YARD, FOOT, INCH, MIL, MICRO_INCH, CUSTOM, UNITLESS`

### FeedServiceTypes
`GOOGLE_BLOB, S3_BLOB, AZURE_BLOB, AZURE_FILE, SHARE_POINT, ONE_DRIVE, GOOGLE_DRIVE, DROPBOX, BOX, GOOGLE_EMAIL, MICROSOFT_EMAIL, ATLASSIAN_JIRA, TRELLO, LINEAR, GIT_HUB_ISSUES, GIT_HUB_PULL_REQUESTS, GIT_HUB_COMMITS, GIT_HUB, INTERCOM_ARTICLES, ZENDESK_ARTICLES, INTERCOM_TICKETS, ZENDESK_TICKETS, GOOGLE_CALENDAR, MICROSOFT_CALENDAR, GOOGLE_CONTACTS, MICROSOFT_CONTACTS, ATTIO_OBJECTS, ATTIO_TASKS, ATTIO_NOTES, PARALLEL`

### EntityState
`INITIALIZED, RESTARTED, CREATED, INGESTED, INDEXED, PREPARED, SANITIZED, EXTRACTED, ENRICHED, CLASSIFIED, CHANGED, ARCHIVED, APPROVED, REJECTED, PENDING, QUEUED, OPENED, CLOSED, FINISHED, PAUSED, RUNNING, SUBSCRIBED, ERRORED, ENABLED, RESOLVED, DISABLED, DELETED`

### MicrosoftCalendarAuthenticationTypes
`USER, CONNECTOR`

### GitHubAuthenticationTypes
`PERSONAL_ACCESS_TOKEN, O_AUTH, CONNECTOR`

### RelationshipDirections
`INCOMING, OUTGOING`

### SearchServiceTypes
`PARALLEL, TAVILY, EXA, EXA_CODE, PERPLEXITY, PODSCAN`

### OpenAIVideoModels
`SORA_2, SORA_2_PRO, CUSTOM`

### JinaModels
`CLIP_IMAGE, EMBED, EMBED_3_0, CUSTOM`

### ConversationRoleTypes
`SYSTEM, ASSISTANT, USER, TOOL`

### NotionTypes
`PAGE, DATABASE`

### MedicalTherapyFacetTypes
`CREATION_DATE`

### DropboxAuthenticationTypes
`USER`

### InvestmentFundFacetTypes
`CREATION_DATE`

### TrelloTypes
`CARD, BOARD`

### IntegrationServiceTypes
`SLACK, WEB_HOOK, EMAIL, TWITTER, MCP`

### MedicalConditionFacetTypes
`CREATION_DATE`

### OAuthProviders
`DROPBOX, BOX, GOOGLE, MICROSOFT, GIT_HUB`

### BlobListingTypes
`PAST, NEW`

### OrganizationFacetTypes
`CREATION_DATE`

### UserTypes
`HUMAN, AGENT`

### EventFacetTypes
`CREATION_DATE`

### CerebrasModels
`LLAMA_4_SCOUT_17B @deprecated(reason: "Has been deprecated, select a different model"), LLAMA_3_3_70B, LLAMA_3_1_8B, QWEN_3_32B, CUSTOM`

### AssemblyAIModels
`BEST, NANO`

### RepoFacetTypes
`CREATION_DATE`

### ContentClassificationServiceTypes
`REGEX, MODEL`

### MicrosoftEmailAuthenticationTypes
`USER, CONNECTOR`

### GraphStrategyTypes
`EXTRACT_ENTITIES_FILTER, EXTRACT_ENTITIES_GRAPH, NONE`

### MailPriority
`NORMAL, LOW, HIGH`

### CohereModels
`EMBED_ENGLISH_3_0, EMBED_MULTILINGUAL_3_0, COMMAND_R, COMMAND_R_202403, COMMAND_R_202408, COMMAND_R_PLUS, COMMAND_R_PLUS_202404, COMMAND_R_PLUS_202408, COMMAND_R7_B_202412, COMMAND_A, COMMAND_A_202503, CUSTOM`

### RegexSourceTypes
`MARKDOWN, METADATA`

### ConversationSearchTypes
`NONE, VECTOR, HYBRID`

### DeepgramModels
`NOVA3_MEDICAL, NOVA3, NOVA2, NOVA2_MEETING, NOVA2_PHONECALL, NOVA2_VOICEMAIL, NOVA2_FINANCE, NOVA2_CONVERSATIONAL_AI, NOVA2_VIDEO, NOVA2_MEDICAL, NOVA2_DRIVETHRU, NOVA2_AUTOMOTIVE, WHISPER_TINY, WHISPER_SMALL, WHISPER_BASE, WHISPER_MEDIUM, WHISPER_LARGE`

### TimedPolicyRecurrenceTypes
`ONCE, REPEAT, MONITOR`

### ConversationTypes
`CONTENT`

### GroqModels
`LLAMA_4_MAVERICK_17B, LLAMA_4_SCOUT_17B, DEEPSEEK_R1_LLAMA_70B_PREVIEW @deprecated(reason: "Has been deprecated, select a different model"), MIXTRAL_8X7B_INSTRUCT @deprecated(reason: "Has been deprecated, select a different model"), LLAMA_3_3_70B, LLAMA_3_2_90B_VISION_PREVIEW @deprecated(reason: "Use LLaMa 4 or newer model"), LLAMA_3_2_11B_VISION_PREVIEW @deprecated(reason: "Use LLaMa 4 or newer model"), LLAMA_3_2_3B_PREVIEW @deprecated(reason: "Use LLaMa 4 or newer model"), LLAMA_3_2_1B_PREVIEW @deprecated(reason: "Use LLaMa 4 or newer model"), LLAMA_3_1_8B @deprecated(reason: "Use LLaMa 4 or newer model"), LLAMA_3_70B @deprecated(reason: "Use LLaMa 4 or newer model"), LLAMA_3_8B @deprecated(reason: "Use LLaMa 4 or newer model"), KIMI_K2_32B, QWEN_3_32B, CUSTOM`

### SharePointAuthenticationTypes
`APPLICATION, USER, CONNECTOR`

### GoogleImageModels
`GEMINI_2_5_FLASH_IMAGE_PREVIEW, GEMINI_3_PRO_IMAGE_PREVIEW, CUSTOM`

### ReductoExtractionModes
`OCR, METADATA, HYBRID`

### ProductFacetTypes
`CREATION_DATE`

### GoogleCalendarAuthenticationTypes
`USER, CONNECTOR`

### AttioAuthenticationTypes
`API_KEY`

### GoogleEmailAuthenticationTypes
`USER, CONNECTOR`

### InvestmentFacetTypes
`CREATION_DATE`

### MistralModels
`MIXTRAL_8X7B_INSTRUCT, MISTRAL_NEMO, MISTRAL_SMALL, MISTRAL_MEDIUM, MISTRAL_LARGE, PIXTRAL_12B_2409, PIXTRAL_LARGE, MISTRAL_EMBED, CUSTOM`

### VoyageModels
`VOYAGE, VOYAGE_3_5, VOYAGE_3_5_LITE, VOYAGE_3_0_LARGE, VOYAGE_3_0, VOYAGE_LITE_3_0, VOYAGE_CODE_3_0, VOYAGE_FINANCE_2_0, VOYAGE_MULTILINGUAL_2_0, VOYAGE_LAW_2_0, VOYAGE_CODE_2_0, CUSTOM`

### FacetValueTypes
`VALUE, RANGE, OBJECT`

### VideoSizeTypes
`HD_PORTRAIT, HD_LANDSCAPE, FULL_HD_PORTRAIT, FULL_HD_LANDSCAPE`

### AuthenticationServiceTypes
`AUTH0, MICROSOFT_GRAPH, CLERK, GOOGLE, O_AUTH, ARCADE`

### TwitterListingTypes
`POSTS, MENTIONS, RECENT_SEARCH`

### AzureDocumentIntelligenceModels
`READ_OCR, LAYOUT, INVOICE, RECEIPT, IDENTIFICATION_DOCUMENT, US_HEALTH_INSURANCE_CARD, US_TAX_FORM, US_TAX_FORM_W2, US_TAX_FORM1098, US_TAX_FORM1098_E, US_TAX_FORM1098_T, US_TAX_FORM1099, US_MARRIAGE_CERTIFICATE, US_MORTGAGE1003, US_MORTGAGE1008, US_MORTGAGE_DISCLOSURE, CREDIT_CARD, US_PAY_STUB, US_BANK_CHECK, US_BANK_STATEMENT`

### SpecificationTypes
`COMPLETION, AGENTIC, TEXT_EMBEDDING, IMAGE_EMBEDDING, EXTRACTION, CLASSIFICATION, SUMMARIZATION, PREPARATION`

### FeedSyncMode
`ARCHIVE, MIRROR`

### SiteTypes
`WATCH, SWEEP, STORAGE`

### PromptStrategyTypes
`OPTIMIZE_SEARCH, REWRITE, NONE`

### EntityTypes
`ACTIVITY, ALERT, CATEGORY, COLLECTION, CONNECTOR, CONTENT, CONVERSATION, EVENT, FEED, INVESTMENT, INVESTMENT_FUND, JOB, LABEL, METADATA, MEDICAL_STUDY, MEDICAL_CONDITION, MEDICAL_GUIDELINE, MEDICAL_DRUG, MEDICAL_DRUG_CLASS, MEDICAL_INDICATION, MEDICAL_CONTRAINDICATION, MEDICAL_TEST, MEDICAL_DEVICE, MEDICAL_THERAPY, MEDICAL_PROCEDURE, OBSERVATION, ORGANIZATION, PERSON, PLACE, PRODUCT, PROJECT, RENDITION, REPO, SITE, SOFTWARE, SPECIFICATION, USER, VIEW, WORKFLOW`

### ContentPublishingServiceTypes
`ELEVEN_LABS_AUDIO, OPEN_AI_IMAGE, GOOGLE_IMAGE, OPEN_AI_VIDEO, TEXT, PARALLEL_RESEARCH`

### MedicalContraindicationFacetTypes
`CREATION_DATE`

### SdkTypes
`DOTNET, PYTHON, NODE_JS`

### MedicalProcedureFacetTypes
`CREATION_DATE`

### EntityResolutionStrategyTypes
`NONE, AUTOMATIC`

### SearchTypes
`KEYWORD, VECTOR, HYBRID`

### GitHubPullRequestAuthenticationTypes
`PERSONAL_ACCESS_TOKEN, O_AUTH, CONNECTOR`

### ReductoOcrModes
`STANDARD, AGENTIC`

### OpenAIImageModels
`GPT_IMAGE_1, GPT_IMAGE_1_MINI, GPT_IMAGE_1_5, CUSTOM`

### RetrievalStrategyTypes
`CONTENT, CHUNK, SECTION`

### MetadataTypes
`CONTENT`

### FeedTypes
`INTERCOM, ZENDESK, NOTION, TWITTER, SLACK, MICROSOFT_TEAMS, DISCORD, REDDIT, WEB, RSS, SITE, YOU_TUBE, EMAIL, ISSUE, PULL_REQUEST, COMMIT, SEARCH, CALENDAR, CRM, RESEARCH, ENTITY, ATTIO`

### StoragePolicyTypes
`ARCHIVE, MINIMIZE`

### FeedConnectorTypes
`GOOGLE, AMAZON, AZURE, SHARE_POINT, ONE_DRIVE, GOOGLE_DRIVE, DROPBOX, BOX, GOOGLE_EMAIL, MICROSOFT_EMAIL, ATLASSIAN, LINEAR, GIT_HUB, INTERCOM, ZENDESK, GOOGLE_CALENDAR, MICROSOFT_CALENDAR, GOOGLE_CONTACTS, MICROSOFT_CONTACTS, ATTIO, PARALLEL`

### MedicalDrugFacetTypes
`CREATION_DATE`

### MCPServerTypes
`REMOTE_SSE, REMOTE_HTTP, LOCAL_NPX`

### ReductoOcrSystems
`HIGHRES, MULTILINGUAL, COMBINED`

### TextTypes
`PLAIN, MARKDOWN, HTML`

### GoogleModels
`GEMINI_2_5_PRO, GEMINI_2_5_PRO_PREVIEW, GEMINI_2_5_PRO_EXPERIMENTAL @deprecated(reason: "Use Gemini 2.5 Pro (Preview) instead."), GEMINI_3_PRO_PREVIEW, GEMINI_3_FLASH_PREVIEW, GEMINI_2_5_FLASH, GEMINI_FLASH_LATEST, GEMINI_2_5_FLASH_PREVIEW, GEMINI_2_5_FLASH_LITE, GEMINI_FLASH_LITE_LATEST, GEMINI_2_0_PRO_EXPERIMENTAL @deprecated(reason: "Use Gemini 2.5 Pro (Preview) instead."), GEMINI_2_0_FLASH_THINKING_EXPERIMENTAL @deprecated(reason: "Use Gemini 2.5 Flash (Preview) instead."), GEMINI_2_0_FLASH_EXPERIMENTAL @deprecated(reason: "Use Gemini 2.0 Flash (Latest) instead."), GEMINI_2_0_FLASH, GEMINI_2_0_FLASH_001, GEMINI_1_5_FLASH_8B, GEMINI_1_5_FLASH_8B_001, GEMINI_1_5_FLASH, GEMINI_1_5_FLASH_001, GEMINI_1_5_PRO, GEMINI_1_5_PRO_001, GEMINI_1_5_FLASH_002, GEMINI_1_5_PRO_002, EMBEDDING_004, CUSTOM`

### TextRoles
`PAGE_HEADER, PAGE_FOOTER, PAGE_NUMBER, TITLE, SECTION_HEADING, FOOTNOTE, CODE, LIST_ITEM, HEADING1, HEADING2, HEADING3, HEADING4, HEADING5, HEADING6, TABLE_COLUMN_HEADER, TABLE_ROW_HEADER, TABLE_CORNER_HEADER, TABLE_CELL, TABLE_CAPTION, TABLE_HEADER, TABLE, IMAGE, IMAGE_CAPTION, FIGURE, FIGURE_CAPTION, BUTTON, DIAGRAM, DIAGRAM_CAPTION, WATERMARK, EQUATION, PARAGRAPH, CHECKBOX, RADIO_BUTTON, COLUMN_HEADER @deprecated(reason: "Use 'TableColumnHeader' instead."), ROW_HEADER @deprecated(reason: "Use 'TableRowHeader' instead."), CORNER_HEADER @deprecated(reason: "Use 'TableCornerHeader' instead.")`

### MailSensitivity
`NONE, NORMAL, PERSONAL, PRIVATE, COMPANY_CONFIDENTIAL`

### AzureDocumentIntelligenceVersions
`V2023_07_31, V2024_02_29_PREVIEW @deprecated(reason: "Use V2024_07_31_PREVIEW instead."), V2024_07_31_PREVIEW, V2024_11_30`

### EntityEnrichmentServiceTypes
`PARALLEL, DIFFBOT, WIKIPEDIA, CRUNCHBASE, FHIR, RADAR`

### LabelFacetTypes
`CREATION_DATE`

### GitHubRepositorySortTypes
`ALPHABETICAL, RANKED`

### DeviceTypes
`DRONE, ROBOT, MOBILE, CAMERA, STREAM, SCREEN, GEOSPATIAL, UNKNOWN`

### OrderDirectionTypes
`ASCENDING, DESCENDING`

### OpenAIModels
`GPT35_TURBO @deprecated(reason: "OpenAI has deprecated this model. Use the GPT-4o Mini model instead."), GPT35_TURBO_0613 @deprecated(reason: "OpenAI has deprecated this model. Use the GPT-4o Mini model instead."), GPT35_TURBO_16K @deprecated(reason: "OpenAI has deprecated this model. Use the GPT-4o Mini model instead."), GPT35_TURBO_16K_0613 @deprecated(reason: "OpenAI has deprecated this model. Use the GPT-4o Mini model instead."), GPT35_TURBO_16K_1106 @deprecated(reason: "OpenAI has deprecated this model. Use the GPT-4o Mini model instead."), GPT35_TURBO_16K_0125 @deprecated(reason: "OpenAI has deprecated this model. Use the GPT-4o Mini model instead."), GPT4 @deprecated(reason: "OpenAI has deprecated this model. Use the GPT-4o model instead."), GPT4_0613 @deprecated(reason: "OpenAI has deprecated this model. Use the GPT-4o model instead."), GPT4_TURBO_VISION_128K @deprecated(reason: "OpenAI has deprecated this model. Use the GPT-4o model instead."), GPT4_TURBO_VISION_128K_1106 @deprecated(reason: "OpenAI has deprecated this model. Use the GPT-4o model instead."), GPT4_32K @deprecated(reason: "OpenAI has deprecated this model. Use the GPT-4o model instead."), GPT4_32K_0613 @deprecated(reason: "OpenAI has deprecated this model. Use the GPT-4o model instead."), GPT4_TURBO_128K, GPT4_TURBO_128K_1106, GPT4_TURBO_128K_0125, GPT4_TURBO_128K_20240409, GPT4O_128K_20240513, GPT4O_128K_20240806, GPT4O_128K_20241120, GPT4O_128K, GPT4O_MINI_128K_20240718, GPT4O_MINI_128K, GPT4O_CHAT_128K, GPT41_NANO_1024K, GPT41_NANO_1024K_20250414, GPT41_MINI_1024K, GPT41_MINI_1024K_20250414, GPT41_1024K, GPT41_1024K_20250414, GPT45_PREVIEW_128K @deprecated(reason: "OpenAI has deprecated this model. Use the GPT 4.1 model instead."), GPT45_PREVIEW_128K_20250227 @deprecated(reason: "OpenAI has deprecated this model. Use the GPT 4.1 model instead."), GPT5_CHAT_400K, GPT5_NANO_400K, GPT5_NANO_400K_20250807, GPT5_MINI_400K, GPT5_MINI_400K_20250807, GPT5_400K, GPT5_400K_20250807, GPT51_400K, GPT51_400K_20251113, GPT52_400K, GPT52_400K_20251211, O1_MINI_128K @deprecated(reason: "OpenAI has deprecated this model. Use the o4 Mini model instead."), O1_MINI_128K_20240912 @deprecated(reason: "OpenAI has deprecated this model. Use the o4 Mini model instead."), O1_PREVIEW_128K, O1_PREVIEW_128K_20240912, O1_200K, O1_200K_20241217, O3_MINI_200K, O3_MINI_200K_20250131, O3_200K, O3_200K_20250416, O4_MINI_200K, O4_MINI_200K_20250416, ADA_002, EMBEDDING_3_SMALL, EMBEDDING_3_LARGE, CUSTOM`

### H3ResolutionTypes
`R0, R1, R2, R3, R4, R5, R6, R7, R8, R9, R10, R11, R12, R13, R14, R15`

### GitHubIssueAuthenticationTypes
`PERSONAL_ACCESS_TOKEN, O_AUTH, CONNECTOR`

### CalendarEventVisibility
`DEFAULT, PUBLIC, PRIVATE, CONFIDENTIAL`

### ModelTypes
`COMPLETION, TEXT_EMBEDDING, IMAGE_EMBEDDING, MULTIMODAL_EMBEDDING, RERANKING`

### CalendarRecurrencePattern
`DAILY, WEEKLY, MONTHLY, YEARLY`

### OpenAIReasoningEffortLevels
`LOW, MEDIUM, HIGH`

### XAIModels
`GROK_4, GROK_3, GROK_3_MINI, CUSTOM`

### MicrosoftTeamsAuthenticationTypes
`USER, CONNECTOR`

### EnvironmentTypes
`DEVELOPMENT, PRODUCTION`

### ReductoEnrichmentModes
`STANDARD, PAGE, TABLE`

### ReplicateModels
`MISTRAL_7B, MISTRAL_7B_INSTRUCT, LLAMA_2_7B, LLAMA_2_13B, LLAMA_2_70B, LLAMA_2_7B_CHAT, LLAMA_2_13B_CHAT, LLAMA_2_70B_CHAT, CUSTOM`
