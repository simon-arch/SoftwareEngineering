## Output
```
=== Initial HTML ===
<div class="base-container">
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
  <p class="after-table">Lorem ipsum dolor.</p>
</div>

=== Counted Tags ===
<p> count: 1
<td> count: 4

=== Replaced Text ===
<div class="base-container">
  <table>
    <tr>
      <th>test</th>
      <th>placeholder</th>
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
  <p class="after-table">Lorem ipsum dolor.</p>
</div>

=== Tree View ===
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
│ │   └─artem@gmail.com
│ └─tr
│   ├─td
│   │ └─Simon
│   └─td
│     └─simon@gmail.com
├─hr
└─p
  └─Lorem ipsum dolor.
```