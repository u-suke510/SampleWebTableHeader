function ScrollTableFrame()
{
    var frame = $(this);

    var headerRow = $(".sample-table.header-row");
    headerRow.css({ top: frame.scrollTop(), left: 0 });
    var headerCol = $(".sample-table.header-col");
    headerCol.css({ top: 0, left: frame.scrollLeft() });
}
