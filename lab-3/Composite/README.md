## Output
```
=== Without Preparation ===
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

=== Preparating ===

[div][OnStart] Prepare Started.
[div][OnClassListApplied] Class List applied:  class='base-container'
[div][OnStylesApplied] Style List applied:  style='width: 100%; height: 100%'
[div][OnEnd] Prepare Ended.

[table][OnStart] Prepare Started.
[table][OnStylesApplied] Style List applied:  style='background-color: white'
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

=== With Preparation ===
<div class="base-container" style="width: 100%; height: 100%">
  <table style="background-color: white">
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
```