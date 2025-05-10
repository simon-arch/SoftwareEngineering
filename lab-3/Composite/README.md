## Output
```
=== Template | Without Preparation ===
<div>
  <table>
    <tr>
      <th>nickname</th>
      <th>email</th>
    </tr>
    <tr>
      <td>Artem</td>
      <td>artem@gmail.com</td>
    </tr>
    <tr>
      <td>Simon</td>
      <td>simon@gmail.com</td>
    </tr>
  </table>
  <hr />
  <p>Lorem ipsum dolor.</p>
</div>

=== Template | Preparating ===

[div][OnStart] Prepare Started.
[div][OnClassListApplied] Class List applied:  class='base-container'
[div][OnEnd] Prepare Ended.

[table][OnStart] Prepare Started.
[table][OnEnd] Prepare Ended.

[tr][OnStart] Prepare Started.
[tr][OnEnd] Prepare Ended.

[th][OnStart] Prepare Started.
[th][OnEnd] Prepare Ended.
[OnTextRendered] nickname

[th][OnStart] Prepare Started.
[th][OnEnd] Prepare Ended.
[OnTextRendered] email

[tr][OnStart] Prepare Started.
[tr][OnEnd] Prepare Ended.

[td][OnStart] Prepare Started.
[td][OnEnd] Prepare Ended.
[OnTextRendered] Artem

[td][OnStart] Prepare Started.
[td][OnEnd] Prepare Ended.
[OnTextRendered] artem@gmail.com

[tr][OnStart] Prepare Started.
[tr][OnEnd] Prepare Ended.

[td][OnStart] Prepare Started.
[td][OnEnd] Prepare Ended.
[OnTextRendered] Simon

[td][OnStart] Prepare Started.
[td][OnEnd] Prepare Ended.
[OnTextRendered] simon@gmail.com

[hr][OnStart] Prepare Started.
[hr][OnEnd] Prepare Ended.

[p][OnStart] Prepare Started.
[p][OnClassListApplied] Class List applied:  class='after-table'
[p][OnEnd] Prepare Ended.
[OnTextRendered] Lorem ipsum dolor.

=== Template | With Preparation ===
<div class="base-container">
  <table>
    <tr>
      <th>nickname</th>
      <th>email</th>
    </tr>
    <tr>
      <td>Artem</td>
      <td>Email Removed</td>
    </tr>
    <tr>
      <td>Simon</td>
      <td>Email Removed</td>
    </tr>
  </table>
  <hr />
  <p class="after-table">Lorem ipsum dolor.</p>
</div>

=== Iterator | Depth First Search ===
div
table
tr
th
th
tr
td
td
tr
td
td
hr
p

=== Iterator | Resetting DFS Iterator ===
div
table
tr
th
th
tr
td
td
tr
td
td
hr
p

=== Template | Breadth First Search ===
div
table
hr
p
tr
tr
tr
th
th
td
td
td
td

=== Template | Resetting BFS Iterator ===
div
table
hr
p
tr
tr
tr
th
th
td
td
td
td

=== Visitor | Counted Tags ===
<p> count: 1
<td> count: 4

=== Visitor | Replaced Text ===
<div class="base-container">
  <table>
    <tr>
      <th>test</th>
      <th>placeholder</th>
    </tr>
    <tr>
      <td>Artem</td>
      <td>Email Removed</td>
    </tr>
    <tr>
      <td>Simon</td>
      <td>Email Removed</td>
    </tr>
  </table>
  <hr />
  <p class="after-table">Lorem ipsum dolor.</p>
</div>

=== Visitor | Tree View ===
div
├─table
│ ├─tr
│ │ ├─th
│ │ │ └─test
│ │ └─th
│ │   └─placeholder
│ ├─tr
│ │ ├─td
│ │ │ └─Artem
│ │ └─td
│ │   └─Email Removed
│ └─tr
│   ├─td
│   │ └─Simon
│   └─td
│     └─Email Removed
├─hr
└─p
  └─Lorem ipsum dolor.

=== State | Switching Tag State to Hidden ===
[State] Hiding <table>

<div class="base-container">
  <hr />
  <p class="after-table">Lorem ipsum dolor.</p>
</div>

=== State | Switching Tag State to Shown ===
[State] Showing <table>

<div class="base-container">
  <table>
    <tr>
      <th>test</th>
      <th>placeholder</th>
    </tr>
    <tr>
      <td>Artem</td>
      <td>Email Removed</td>
    </tr>
    <tr>
      <td>Simon</td>
      <td>Email Removed</td>
    </tr>
  </table>
  <hr />
  <p class="after-table">Lorem ipsum dolor.</p>
</div>

=== Command | Reverting Commands ===
[Undo] Reverting AddChild
[Undo] Reverting AddChild
[Undo] Reverting AddClass
[Undo] Reverting SetText

=== Command | Reverted HTML ===
<div class="base-container">
  <table>
    <tr>
      <th>test</th>
      <th>placeholder</th>
    </tr>
    <tr>
      <td>Artem</td>
      <td>Email Removed</td>
    </tr>
    <tr>
      <td>Simon</td>
      <td>Email Removed</td>
    </tr>
  </table>
  <hr />
</div>

=== Command | Reverting Commands ===
[Undo] Reverting AddChild
[Undo] Reverting AddChild

=== Command | Reverted HTML ===
<div class="base-container">
  <table>
    <tr>
      <th>test</th>
      <th>placeholder</th>
    </tr>
    <tr>
      <td>Artem</td>
      <td>Email Removed</td>
    </tr>
  </table>
</div>
```