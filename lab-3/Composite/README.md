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

=== Switching Tag State to Hidden ===
[State] Hiding <table>

<div class="base-container">
  <hr />
  <p class="after-table">Lorem ipsum dolor.</p>
</div>

=== Switching Tag State to Shown ===
[State] Showing <table>

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
```