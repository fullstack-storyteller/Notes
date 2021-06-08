# Learning MarkDown to write better notes

## Links

This is the resource from where you learned [Markdown](https://www.ionos.com/digitalguide/websites/web-development/markdown/)

## Images

Below will be an image with caption.

![alt text which comes when image is not there goes here: Picture of a dog from the internet.](https://images.unsplash.com/photo-1543466835-00a7907e9de1?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxleHBsb3JlLWZlZWR8Mnx8fGVufDB8fHx8&auto=format&fit=crop&w=250&q=60)

Photo Link: `[![Here is an example image](https://example.com/image.jpg)](https://example.com)`

[![alt text which comes when image is not there goes here: Picture of a dog from the internet.](https://images.unsplash.com/photo-1543466835-00a7907e9de1?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxleHBsb3JlLWZlZWR8Mnx8fGVufDB8fHx8&auto=format&fit=crop&w=250&q=60)](Click me! I'm a photo link)

## Using code - remember to use a backslash (\\) as escape character

`[some text which will be shown for link] (link address)`

This is an \*example with an asterisk\*.

This is an _example with an asterisk_.

## Word formatting

`*Italic Text* _Italic Text_`
`**Bold Text** __Bold Text__`
`***Italic and Bold Text***`
`___Italic and Bold Text___`

`~~This text is struckthrough.~~ This one isn’t.`
Ex: ~~This text is struckthrough.~~ This one isn’t.

**_Text can’t be underlined in Markdown._**

**Headings**
`# Heading 1`
`## Heading 2`
`### Heading 3`
`#### Heading 4`
`##### Heading 5`
`###### Heading 6`

**_Paragraphs_**
The Markdown language works with hard line breaks to separate paragraphs from each other. To create a completely new block of text (

tag), simply add an empty line. Important note: for Markdown, it’s sufficient if the line is visually empty. So if the line contains white spaces like tabs or spaces, the parser will ignore them and consider the line to be empty. If you want to create a line break like the
tag, add two spaces at the end of a line.

## Quotes

Below is how quotes are written in Markdown

> This is an **embedded section**. Let's call this A.
> The section A continues here

Another section:

> This is another **embedded section**. Let's call this B.
> This section B also continues here

This line isn’t embedded any more.

## Lists

Bulleted List

- Point 1
  - point 1.1
  - point 1.2
- Point 2
- Point 3
  - point 3.1

Numbered List

1. Point 1

   > embedded Point 1 of 1

   > embedded point 2 of 1

2. Point 2
   1. point 1 of 2
   2. point 2 of 2
3. Point 3

## Code

This is `code`. Refer below for any language specific multiline code snippets.

```text
This is normal, continuous text.
  This is the first line of the code block.
     The second line is further indented.
  This is another line of code block.
This is where continuous text begins again.
```

```javascript
let a = 0;
console.log(a);
```

Simply, trying to display a url in a paragraph, `https://example.com` (use backticks \`) or <https://example.com> (use <>)

## Tables

| Column 1 | Column 2 |
| -------- | -------- |
| A        | B        |
| C        | D        |
