
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class MultiSelectComboBox : ComboBox
{
    private readonly List<CheckBox> checkboxes = new List<CheckBox>();
    private ToolStripDropDown dropDown;
    private ToolStripControlHost host;
    private Panel panel;

    public List<KeyValuePair<int, string>> SelectedItems
    {
        get
        {
            return checkboxes
                .Where(cb => cb.Checked)
                .Select(cb => (KeyValuePair<int, string>)cb.Tag)
                .ToList();
        }
    }

    public event EventHandler SelectionChanged;

    public MultiSelectComboBox()
    {
        DrawMode = DrawMode.OwnerDrawFixed;
        DropDownHeight = 1; // hide built-in dropdown
        Click += ShowDropdown;
    }

    public void SetItems(List<KeyValuePair<int, string>> items)
    {
        checkboxes.Clear();
        panel = new Panel { AutoSize = true };

        foreach (var item in items)
        {
            var cb = new CheckBox
            {
                Text = item.Value,
                Tag = item,
                AutoSize = true,
                Checked = false
            };
            cb.CheckedChanged += (s, e) => { SelectionChanged?.Invoke(this, EventArgs.Empty); };
            panel.Controls.Add(cb);
            checkboxes.Add(cb);
        }

        host = new ToolStripControlHost(panel) { AutoSize = true };
        dropDown = new ToolStripDropDown();
        dropDown.Items.Clear();
        dropDown.Items.Add(host);
    }

    protected override void OnDrawItem(DrawItemEventArgs e)
    {
        e.DrawBackground();
        e.Graphics.DrawString(
            string.Join(", ", SelectedItems.Select(x => x.Value)),
            e.Font,
            new SolidBrush(e.ForeColor),
            e.Bounds);
        base.OnDrawItem(e);
    }

    private void ShowDropdown(object sender, EventArgs e)
    {
        if (dropDown != null && !dropDown.Visible)
        {
            dropDown.Show(this, 0, Height);
        }
    }
}
