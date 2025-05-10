## Output
```
=== Initial HTML (Tags renamed for further clarity) ===
<div-a class="base-container">
  <table-a.1>
    <tr-a.1.A>
      <th-a.1.A.I>nickname</th-a.1.A.I>
      <th-a.1.A.II>email</th-a.1.A.II>
    </tr-a.1.A>
    <tr-a.1.B>
      <td-a.1.B.I>Artem</td-a.1.B.I>
      <td-a.1.B.II>artem@gmail.com</td-a.1.B.II>
    </tr-a.1.B>
    <tr-a.1.C>
      <td-a.1.C.I>Simon</td-a.1.C.I>
      <td-a.1.C.II>simon@gmail.com</td-a.1.C.II>
    </tr-a.1.C>
  </table-a.1>
  <hr-a.2 />
  <p-a.3 class="after-table">Lorem ipsum dolor.</p-a.3>
</div-a>

=== Depth First Search ===
div-a
table-a.1
tr-a.1.A
th-a.1.A.I
th-a.1.A.II
tr-a.1.B
td-a.1.B.I
td-a.1.B.II
tr-a.1.C
td-a.1.C.I
td-a.1.C.II
hr-a.2
p-a.3

=== Resetting DFS Iterator ===
div-a
table-a.1
tr-a.1.A
th-a.1.A.I
th-a.1.A.II
tr-a.1.B
td-a.1.B.I
td-a.1.B.II
tr-a.1.C
td-a.1.C.I
td-a.1.C.II
hr-a.2
p-a.3

=== Breadth First Search ===
div-a
table-a.1
hr-a.2
p-a.3
tr-a.1.A
tr-a.1.B
tr-a.1.C
th-a.1.A.I
th-a.1.A.II
td-a.1.B.I
td-a.1.B.II
td-a.1.C.I
td-a.1.C.II

=== Resetting BFS Iterator ===
div-a
table-a.1
hr-a.2
p-a.3
tr-a.1.A
tr-a.1.B
tr-a.1.C
th-a.1.A.I
th-a.1.A.II
td-a.1.B.I
td-a.1.B.II
td-a.1.C.I
td-a.1.C.II
```