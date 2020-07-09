# Curnow.biz.MessageCard

Legacy actionable message card model for .NET based applications. Ideal for sending actionable message cards to Microsoft Teams using objects instead of JSON strings.

There are several classes provided that offers a complete implementation of the Actionable Message Card JSON schema. A complete description of the MessageCard schema and layout can be found on Github [here](https://github.com/OfficeDev/outlook-dev-docs/blob/master/docs/actionable-messages/message-card-reference.md).

## Namespaces

You must include the following usings in your code to use the classes:

```csharp
using Curnow.biz.MessageCard;
using Curnow.biz.MessageCard.Actions;
using Curnow.biz.MessageCard.Inputs;
using Curnow.biz.MessageCard.Section;
```

## Constructing a MessageCard in Code

The example below takes the following MessageCard JSON string and implements it using the MessageCard classes.

```json
{
  "summary": "Card \"Test card\"",
  "themeColor": "0078D7",
  "title": "Card created: \"Name of card\"",
  "sections": [
    {
      "activityTitle": "David Claux",
      "activitySubtitle": "9/13/2016, 3:34pm",
      "activityImage": "https://connectorsdemo.azurewebsites.net/images/MSC12_Oscar_002.jpg",
      "facts": [
        {
          "name": "Board:",
          "value": "Name of board"
        },
        {
          "name": "List:",
          "value": "Name of list"
        },
        {
          "name": "Assigned to:",
          "value": "(none)"
        },
        {
          "name": "Due date:",
          "value": "(none)"
        }
      ],
      "text": "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
    }
  ],
  "potentialAction": [
    {
      "@type": "ActionCard",
      "name": "Set due date",
      "inputs": [
        {
          "@type": "DateInput",
          "id": "dueDate",
          "title": "Select a date"
        }
      ],
      "actions": [
        {
          "@type": "HttpPOST",
          "name": "OK",
          "target": "https://..."
        }
      ]
    },
    {
      "@type": "ActionCard",
      "name": "Move",
      "inputs": [
        {
          "@type": "MultichoiceInput",
          "id": "move",
          "title": "Pick a list",
          "choices": [
            { "display": "List 1", "value": "l1" },
            { "display": "List 2", "value": "l2" }
          ]
        }
      ],
      "actions": [
        {
          "@type": "HttpPOST",
          "name": "OK",
          "target": "https://..."
        }
      ]
    },
    {
      "@type": "ActionCard",
      "name": "Add a comment",
      "inputs": [
        {
          "@type": "TextInput",
          "id": "comment",
          "isMultiline": true,
          "title": "Enter your comment"
        }
      ],
      "actions": [
        {
          "@type": "HttpPOST",
          "name": "OK",
          "target": "https://..."
        }
      ]
    },
    {
      "@type": "OpenUri",
      "name": "View in Trello",
      "targets": [
        { "os": "default", "uri": "https://..." }
      ]
    }
  ]
}
```

When building the card, everything starts with a MessageCard object, as follows:

```csharp
MessageCard card = new MessageCard
{ 
    Summary = "Card \"Test Card\"",
    ThemeColor = "0078D7",
    Title = "Card created: \"Name of card\""
};
```
## Sections
To add the card Section information, we need to populate the Sections collection property of the MessageCard object with one or more Section objects, as follows:

```csharp
card.Sections = new List<Section>()
{
    new Section
    {
        ActivityTitle = "David Claux",
        ActivitySubtitle = "9/13/2016, 3:34pm",
        ActivityImage = "https://connectorsdemo.azurewebsites.net/images/MSC12_Oscar_002.jpg",
        Facts = new List<Fact>()
        {
            new Fact { Name = "Board:", Value = "Name of board"},
            new Fact { Name = "List:", Value = "Name of list"},
            new Fact { Name = "Assigned to:", Value = "(none)"},
            new Fact { Name = "Due date:", Value = "(none)"}
        },
        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."
    }
};
```
In the example above, the Section contains Facts, so the Section object Fact collection property is populated with multiple Fact objects.

## Card Actions

We can now move on to populating the MessageCard objects Actions collection property. This property is a collection of objects whose base type is ActionBase. The Actions available are:

- ActionCard
- HttpPOSTAction
- OpenUriAction
- InvokeAddInCommandAction

These classes implement all of the properties defined in the MessageCard JSON schema for Action types.

```csharp
card.Actions = new List<ActionBase>()
{
    new ActionCard
    {
        Name = "Set due date",
        Inputs = new List<InputBase>()
        {
            new DateInput { Id = "dueDate", Title = "Select a date"}
        },
        Actions = new List<ActionBase>()
        {
            new HttpPOSTAction { Name = "OK", Target="https://..."}
        }
    },
    new ActionCard
    {
        Name = "Move",
        Inputs = new List<InputBase>()
        {
            new MultiChoiceInput
            { 
                Id = "move",
                Title = "Pick a list",
                Style = Style.Expanded,
                Choices = new List<Choice>()
                {
                    new Choice { Display = "List 1", Value = "l1"},
                    new Choice { Display = "List 2", Value = "l2"}
                }
            }
        },
        Actions = new List<ActionBase>()
        {
            new HttpPOSTAction { Name = "OK", Target = "https://..."}
        }
    },
    new ActionCard
    {
        Name = "Add a comment",
        Inputs = new List<InputBase>()
        {
            new TextInput { Id = "comment", IsMultiLine = true, Title = "Enter your comment"}
        },
        Actions = new List<ActionBase>()
        {
            new HttpPOSTAction
            {
                Name = "OK",
                Target = "https://...",
                Body = "comment={{comment.value}}"
            }
        }
    },
    new OpenUriAction
    {
        Name = "View in Trello",
        Targets = new List<Target>
        {
            new Target { OS = TargetOS.Default, Uri="https://..."}
        }
    }
};
```
## ActionCard Inputs collection
The Inputs property is a collection of objects whose base type is InputBase. The input types are:

- TextInput
- DateInput
- MultiChoiceInput

These classes implement all of the properties defined in the MessageCard JSON schema for Input types.

## Returning a JSON string from a MessageCard Object

In order for the card to be sent to Teams (or any other application that supports message cards), raw JSON needs to be posted to an incoming webhook. The MessageCard class implements a simple method called ToJson() and is used as follows (assuming the variable card is an instance of MessageCard):

```csharp
string json = card.ToJson();
```
