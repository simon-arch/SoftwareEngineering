## Output
```
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

=== Subscribing to 'mouseover' event
=== Invoking events
[mouseover] Event invoked.

=== Subscribing to 'focus' event
=== Invoking events
[focus] Event invoked.
[mouseover] Event invoked.

=== Subscribing to 'click' event
=== Invoking events
[focus] Event invoked.
[click] Event invoked.
[mouseover] Event invoked.

=== Unsubscribing from 'focus' event
=== Invoking events
[click] Event invoked.
[mouseover] Event invoked.
```