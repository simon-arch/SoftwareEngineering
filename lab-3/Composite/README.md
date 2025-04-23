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

=== Loading image from the file system.
[ISourceStrategy] Image loaded from the file system. | Source: /images/photo.jpg
<img src='/images/photo.jpg' />

=== Loading image from the web.
[ISourceStrategy] Image loaded from the web. | Source: https://picsum.photos/200
<img src='https://picsum.photos/200' />

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
  <img src="/images/photo.jpg" />
  <img src="https://picsum.photos/200" />
</div>
```