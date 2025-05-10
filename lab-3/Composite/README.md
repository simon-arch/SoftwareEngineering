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

=== Reverting Commands ===
[Undo] Reverting AddChild
[Undo] Reverting AddChild
[Undo] Reverting AddClass
[Undo] Reverting SetText

=== Reverted HTML ===
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
</div>

=== Reverting Commands ===
[Undo] Reverting AddChild
[Undo] Reverting AddChild

=== Reverted HTML ===
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
  </table>
</div>
```